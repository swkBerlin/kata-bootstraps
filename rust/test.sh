#!/usr/bin/env bash
set -e

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

docker run \
  -v "${DIR}:/root/rust-kata" \
  -w /root/rust-kata \
  -i -t frolvlad/alpine-rust \
  cargo test
