# file : apb.awk
# desc : APB a testing library for AWK
#        @include this and all files to test into a awk test file e.g. test_prog.awk
# auth : Jens Koesling

number_of_tests = 0
passed_tests = 0
failed_tests = 0

function test_w_cmp (name, fct, expr, result) {
    # Main testing funtion
    # name: description of the test, e.g. "year is leapyear if divisible by 400"
    # fct : function used to compare expression expr to the expected result result
    number_of_tests += 1
    if (@fct(expr, result)) {
        status = "ok"
        passed_tests += 1
    }
    else {
        status = "not ok"
        failed_tests += 1
    }

    ret = sprintf("%s %d - %s", status, ++testnum, name)
    # printf ret
    return ret
}

# test_equal() ###################################
function eq (a, b) {
    return (a == b)
}

function test_equal (name, expr, result) {
    return (test_w_cmp(name, "eq", expr, result))
}

# test_leq() #####################################
function leq (a, b) {
    return (a <= b)
}

function test_leq (name, expr, result) {
    return (test_w_cmp(name, "leq", expr, result))
}

# comparison for arrays 
function lcmp (l,r) {
    equiv = 1
    if (isarray(l)) {
        for (i in l) {
            if (i in r) {
                # dark corner: 
                # (i in r) is not the same as (r[i] == val)
                # the second changes the array and sets previously uninitialized entries to ""
                equiv = equiv && (lcmp(l[i],r[i]))
            }
            else {
                equiv = 0
            }
        }
    }
    else {
        equiv = (l == r)
    }
    return equiv
}

function arr_eq (l,r) {
    return (lcmp(l,r) && lcmp(r,l))
}

##################################################
function test_report () {
    print ""
    print "From", number_of_tests, "tests"    
    print (passed_tests + 0), "passed and"
    print (failed_tests + 0), "failed."
}

