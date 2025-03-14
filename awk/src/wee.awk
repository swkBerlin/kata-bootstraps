#! /usr/bin/gawk -E

# file : wee.awk
# desc : A wee program in awk

function min(a, b) {
    if ( a <= b ) { return a }
    else { return b }
}
function max(a, b) {
    if ( a >= b ) { return a }
    else { return b }
}

BEGIN { 
    knowledge = "p"
    answer = 42
}

{
    if ( min($1, answer) == 42 ) {
        knowledge="poste"
    }
}

END {
    print "(wee.awk): I knew that a " knowledge "riori."
}

