#!/bin/bash

echo "In order to assure that we have a failing test this script"
echo "  execute the 1st argument and looks for the 2nd argument"
echo "  and fails if it is not found in the output"
if [ "$#" -eq 2 ]; then
  echo "1st argument: " $1
  echo "2nd argument: " $2
  echo ""
else
  echo "Arguments are not equals to 2"
  echo "All Arguments values:" $@
  exit 1
fi

TEMPFILE=$(mktemp)
FAILED="failed"
(eval "$1" && echo okay || echo "$FAILED") | tee $TEMPFILE
grep -F -- "$2" $TEMPFILE && (cat $TEMPFILE | tail -n1 | grep -q "$FAILED")
