set -e

docker build . -t golang
docker run -v $(pwd):/go/src/game-of-life/ -it golang /bin/bash
