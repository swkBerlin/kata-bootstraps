
# Golang with [ginkgo](https://github.com/onsi/ginkgo)


If you have Golang installed locally and your $GOPATH already configured,



##Run

```
go mod tidy


./run_tests.sh
```

##GoLand setup

hints to get it running in GoLand
https://gist.github.com/jtigger/24da8b7d768b889758b8d7a39d429858

#Docker
If you do not have Golang but do have Docker,

```
./docker_up.sh   # volume-mounts this directory

## inside the Docker container
cd /kata
./run_tests.sh
```

You can continue to edit your local source and test files using your choice of editor.
