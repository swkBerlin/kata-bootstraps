#!/usr/bin/env bash
set -e

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

docker run \
  -v "${DIR}:/root/clojure-kata" \
  -w /root/clojure-kata \
  -i -t clojure:tools-deps \
  clojure -X:test
