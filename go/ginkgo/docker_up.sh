set -e

docker build . -t golang
docker run -v $(pwd):/go/kata -it golang /bin/bash

