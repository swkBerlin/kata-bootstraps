#!/bin/bash

docker run \
  -v $(pwd):/kata \
  -w /kata \
  -i gradle \
  gradle test
