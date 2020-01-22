#!/bin/sh
set -e

# Build image
docker build -t cppdev  . 
# Run with bash
docker run --rm -it -v $(pwd):/project/ cppdev
