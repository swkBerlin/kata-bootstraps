# CMake Setup

This is a simple bootstrap project for C++ using [**CMake**](https://cmake.org/download/) and [**doctest**](https://github.com/onqtam/doctest)

You can edit the CMakeLists.txt file to set the targeted C++ Standard (Default is C++11) in the variable _CXX_STANDARD_.

## Prerequisites

### Requirements

- C++ Compiler with possibily support to modern standards (e.g. gcc >= 5, clang >= 3.8, Visual Studio >= 2013)
- CMake (>= 3.10)

### Docker

If you have Docker installed on your machine (Linux/Mac/Windows with WSL), you can start a docker container by using the script:

`docker_up.sh`

The script will build a docker image with all the requirements (gcc compiler, cmake, make) and will run the docker container with a bash prompt in the `/project` folder.

Once you're done with coding, typing `exit` in the shell will stop and automatically remove the docker container (not the image).

### Native environment

CMake is a cross-platform build system generator on Windows/Linux/Mac.
It doesn't build the project itself, it generates the necessary files for a native build tool (like Make or Visual Studio) to perform the compilation.

When you run CMake for the first time in a project, it performs System Introspection.
It automatically detects the host environment and selects a default "Generator" and "Toolchain" (compiler, linker, etc.) based on what is available in your PATH.

To see your default generator, run this command on your terminal :

```bash
$ cmake --help
The following generators are available on this platform (* marks default):
* Visual Studio 18 2026        = Generates Visual Studio 2026 project files.
  MinGW Makefiles              = Generates a make file for use with
                                 mingw32-make.
  Unix Makefiles               = Generates standard UNIX makefiles.
  Ninja                        = Generates build.ninja files.
```

#### Default configuration

- Windows: If Visual Studio is installed, CMake usually defaults to the MSVC (Microsoft Visual C++) compiler and generates a .sln (Solution) file.
- Linux: It usually defaults to Unix Makefiles and uses gcc or clang depending on the system configuration.

#### Custom configuration

To force CMake to use specific configurator and/or compilers by setting the `CMAKE_C_COMPILER` and `CMAKE_CXX_COMPILER` variables at configure step or by specific file 
configuration with `--toolchain` or variable `CMAKE_TOOLCHAIN_FILE` :

```bash
$ cmake -G Ninja -DCMAKE_C_COMPILER=clang -DCMAKE_CXX_COMPILER=clang++
```

Or by :

```bash
$ cmake -G Ninja -DCMAKE_TOOLCHAIN_FILE=<My_custom_file>
```

Or by :

```bash
$ cmake -G Ninja --toolchain <My_custom_file>
```

## Build and launch test suite

To run the project, just open a terminal and run the following commands:

```bash
$ cmake -B build          # 1. Configure step with default configuration
$ cmake --build build     # 2. Build test suite executables
$ ctest --test-dir build  # 3. Run test suite
```

## IDE integration

If you want to integrate the project on your prefered IDE, following next section :

### VS Code

https://code.visualstudio.com/docs/languages/cpp
