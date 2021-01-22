#!/bin/bash

echo "In order to assure that we have a failing test this script:"
echo "  executes the 1st argument"
echo "   - expects it to fail"
echo "   - expects the output to contain the 2nd argument"
echo "  and fails unless those two conditions are meet"
if [ "$#" -eq 2 ]; then
  echo "1st argument: " $1
  echo "2nd argument: " $2
  echo ""
else
  echo "Arguments are not equals to 2"
  echo "All Arguments values:" $@
  exit 1
fi

NO_COLOR='\033[0m'
BOLD_GREEN='\033[1;32m'
BOLD_LIGHT_RED='\033[1;91m'

TEMPFILE=$(mktemp)
FAILED="failed"
(eval "$1" && echo okay || echo "$FAILED") | tee $TEMPFILE
grep -F -- "$2" $TEMPFILE && (cat $TEMPFILE | tail -n1 | grep -q "$FAILED")

if [ "$?" -eq 0 ]; then
  echo " "
  echo "${BOLD_GREEN}Successfully failed a test.${NO_COLOR}"
  exit 0
else
  echo " "
  echo "${BOLD_LIGHT_RED}Please make sure there is a failing test example!${NO_COLOR}"
  exit 1
fi
