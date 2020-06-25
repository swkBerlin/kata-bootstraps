If you have Golang installed locally and your $GOPATH already configured,

https://github.com/onsi/ginkgo

```
go get github.com/onsi/ginkgo/ginkgo  # installs the ginkgo CLI
go get github.com/onsi/gomega         # fetches the matcher library

./run_tests.sh
```


If you do not have Golang but do have Docker,

```
./docker_up.sh   # volume-mounts this directory

## inside the Docker container
cd /go/src/game-of-life
./run_tests.sh
```

You can continue to edit your local source and test files using your choice of editor.
