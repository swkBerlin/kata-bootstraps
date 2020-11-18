#!/bin/bash

expected_test_output='Expected: 42';
output=$(yarn test 2>&1);

echo "$output";

if [[ $output =~ $expected_test_output ]]; then
  echo "Successfully failed a test";
  exit 0;
else
  RED='\033[0;31m';
  NO_COLOR='\033[0m';
  echo -e "${RED}Please make sure there is a failing test example.${NO_COLOR}" 1>&2;
  exit 1;
fi
