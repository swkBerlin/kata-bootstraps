# C++ / GoogleMock

Kata starting point using [GoogleMock](https://github.com/google/googletest).

## Requirements

- C++ compiler (g++ or clang++)
- GoogleTest / GoogleMock (`libgmock-dev` on Debian/Ubuntu)

## Run tests

```sh
make test
```

## Docker / Dev Container

The `.devcontainer/devcontainer.json` uses the [cyber-dojo clangpp+googlemock](https://github.com/cyber-dojo-languages/clangpp_googlemock) image which has clang++ and GoogleMock pre-installed.

Open in VS Code with the Dev Containers extension, then run:

```sh
make test
```
