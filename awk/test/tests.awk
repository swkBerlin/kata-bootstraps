#! /usr/bin/gawk -E

# FILE : test/tests.awk
# desc : Testing src/wee.awk

@include "src/wee.awk"
@include "src/apb.awk"

BEGIN { 
    # ##################################################
    # FIXTURES

    answer_exp = 42
    split("ABCDE", letters_exp, "") 


    # ##################################################
    # TESTS

    print "Basic tests"

    print test_equal("This test passes", 1, 1)
    print test_equal("This test fails", 0, 1)

    arr_in[1] = "A"
    arr_in[2] = "B"
    arr_in[3] = "C"
    arr_in[4] = "D"
    arr_in[5] = "E"
    print test_equal("Testing arrays", arr_eq(arr_in, letters_exp), 1)

    delete arr_in

    print test_leq("The minimum of two numbers is smaller than their maximum", min(23, 42), max(23, 42) )

    # ##################################################
    # REPORT
    test_report() 
}
