#!/bin/bash
# install ./kata.sh ~/bin/kata
# saner programming env: these switches turn some bugs into errors
set -o errexit -o pipefail -o noclobber -o nounset

usage() {
    echo "Usage: $0 [-n <name>] [ <target directory> ]" 1>&2
    echo "example : $0 -n java-junit5" 1>&2
    echo "Usage: $0 [-p <path of kata in repo>] [-i <init command>] [-s <git source repo>] [ <target directory> ]" 1>&2
    echo "example : $0 -p /java/junit5 -i gradlew -s https://github.com/swkBerlin/kata-bootstraps.git" 1>&2
    
    exit 1
}
# bootstraps a kata from git, copies it to a target directory, initializes it if required
bootstrap() {
    # path             : $1
    # git repo         : $2
    # target directory : $3
    # init command     : $4
    b_path=$1
    b_gitRepo=$2
    b_target_dir=$3
    if [ ! -z ${4+x} ]; then
        b_init_command=$4
    else
        b_init_command=""
    fi

    # check if target directory exists
    if [ -d "$b_target_dir" ]; then
        echo "$b_target_dir already exists " 1>&2
        exit 2
    fi

    # Create a temporary folder for git repo
    tfolder=$(mktemp -d /tmp/kata.XXXXXXXXX)

    git clone $b_gitRepo $tfolder

    # Copy a specific starter to a new folder in the current folder
    cp -r -f "$tfolder/$b_path" "$b_target_dir"

    # Run initialization command if needed
    if [ $b_init_command ]; then
        full_command="$b_target_dir/$b_init_command"
        ${full_command}
    fi

    # cleanup temporary files
    rm -rf /tmp/kata.*
}

bootstrapFromName() {
    b_name=$1
    declare -a boostrapParams
    if [ $b_name = "empty-java-junit5" ]; then
        boostrapParams=("/java/junit5" "https://github.com/swkBerlin/kata-bootstraps.git" "gradlew")
    elif [ $b_name = "empty-java-assertj" ]; then
        boostrapParams=("/java/assert_j" "https://github.com/swkBerlin/kata-bootstraps.git" "gradlew")
    elif [ $b_name = "empty-java-cucumber" ]; then
        boostrapParams=("/java/cucumber" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    elif [ $b_name = "empty-elixir" ]; then
        boostrapParams=("/java/elixir" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    elif [ $b_name = "empty-csharp-dotnetcore" ]; then
        boostrapParams=("/csharp/dotnet-core" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    elif [ $b_name = "empty-node-jasmine" ]; then
        boostrapParams=("/js/jasmine-node/" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    elif [ $b_name = "empty-node-jest" ]; then
        boostrapParams=("/js/js-jest-node" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    elif [ $b_name = "empty-js-jasmine" ]; then
        boostrapParams=("/js/jasmine" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    elif [ $b_name = "empty-node-mocha" ]; then
        boostrapParams=("/js/mocha-tests" "https://github.com/swkBerlin/kata-bootstraps.git" "")
    else
        echo "$b_name is not a recognised name" 1>&2
        exit 2
    fi
    
    bootstrap ${boostrapParams[0]} ${boostrapParams[1]} $targetDirectory ${boostrapParams[2]}
}

if [ $# -eq 0 ]; then
    usage
    exit 1
fi

# -allow a command to fail with !’s side effect on errexit
# -use return value from ${PIPESTATUS[0]}, because ! hosed $?
! getopt --test >/dev/null
if [[ ${PIPESTATUS[0]} -ne 4 ]]; then
    echo 'I’m sorry, `getopt --test` failed in this environment.'
    exit 1
fi

OPTIONS=n:p:i:s:h
LONGOPTS=name:,path:,init-commant:,source-repo:,help

# -regarding ! and PIPESTATUS see above
# -temporarily store output to be able to check for errors
# -activate quoting/enhanced mode (e.g. by writing out “--options”)
# -pass arguments only via   -- "$@"   to separate them correctly
! PARSED=$(getopt --options=$OPTIONS --longoptions=$LONGOPTS --name "$0" -- "$@")
if [[ ${PIPESTATUS[0]} -ne 0 ]]; then
    # e.g. return value is 1
    #  then getopt has complained about wrong arguments to stdout
    exit 2
fi
# read getopt’s output this way to handle the quoting right:
eval set -- "$PARSED"

# now enjoy the options in order and nicely split until we see --
while true; do
    case "$1" in
    -h | --help)
        usage
        return 1
        ;;
    -n | --name)
        kataName="$2"
        shift 2
        ;;
    -p | --path)
        kataPath="$2"
        shift 2
        ;;
    -i | --init-command)
        initCommandName="$2"
        shift 2
        ;;
    -s | --source-repo)
        gitSourceRepo="$2"
        shift 2
        ;;
    --)
        shift
        break
        ;;
    *)
        echo "Programming error"
        exit 3
        ;;
    esac
done

# handle non-option arguments
if [[ $# -ne 1 ]]; then
    targetDirectory="./$kataName"
else
    targetDirectory=$1
fi

argsAreValid=true
kataNameProvided=true
kataPathProvided=true
# check for required inputs
# We must either provide a pre-bundled boostrap name or a path
if [ -z ${kataName+x} ]; then
    kataNameProvided=false
else
    kataNameProvided=true
fi
if [ -z ${kataPath+x} ]; then
    kataPathProvided=false
else
    kataPathProvided=true
fi

if [ -z ${gitSourceRepo+x} ]; then
    gitSourceRepo="https://github.com/swkBerlin/kata-bootstraps.git"
    echo "git source repo defaulted to $gitSourceRepo"
fi

if [ -z ${initCommandName+x} ]; then
    initCommand=""
else
    initCommand="$targetDirectory/$initCommandName"
fi

if [ $kataNameProvided = true ] || [ $kataPathProvided = true ]; then
    argsAreValid=true
else
    echo "$kataNameProvided $kataPathProvided"
    echo "kata name (-n option) is required. i.e. java-junit5" 1>&2
    echo "or" 1>&2
    echo "kata path (-p option) is required. i.e. /java/junit5" 1>&2
    argsAreValid=false
fi

if [ $argsAreValid = false ]; then
    exit 2
fi

if [ $kataNameProvided = true ]; then
    bootstrapFromName $kataName
elif [ $kataPathProvided = true ]; then
    bootstrap $kataPath $gitSourceRepo $targetDirectory $initCommand
fi
