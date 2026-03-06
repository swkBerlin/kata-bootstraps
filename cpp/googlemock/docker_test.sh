#!/bin/bash

docker run \
  -v $(pwd):/kata \
  -w /kata \
  -i ghcr.io/cyber-dojo-languages/clangpp_googlemock:806bfec \
  sh -c "make kata_tests CXX=clang++ && ./kata_tests"
