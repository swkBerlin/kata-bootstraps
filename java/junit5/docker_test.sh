#!/bin/bash

docker run \
  -v $(pwd):/kata \
  -w /kata \
  -i gradle:7.6-jdk11 \
  gradle test
