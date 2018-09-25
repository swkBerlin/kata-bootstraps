#!/usr/bin/env bash
set -e

DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

docker run \
  -v "${DIR}:/root/fsharp-kata" \
  -w /root/fsharp-kata \
  -i -t microsoft/dotnet \
  dotnet test KatasTests
