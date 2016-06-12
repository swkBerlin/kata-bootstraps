CMake Setup
==========

This is a simple bootstrap project for C++ using [**CMake**](https://cmake.org/download/) and [**doctest**](https://github.com/onqtam/doctest)

You can edit the CMakeLists.txt file to set the targeted C++ Standard (Default is C++11) in the variable _CXX_STANDARD_.

### Requirements

* C++ Compiler with possibily support to modern standards (e.g. gcc >= 5, clang >= 3.8, Visual Studio >= 2013)
* CMake

### Unix-Like Setup

To run the project, just open a terminal (on Linux/Mac) and run the following commands:

```
cd /path/to/this/project
mkdir build && cd build
cmake ..
```

To run the tests just run:

```
make
make test
```

### Windows 

If you have Visual Studio, just launch the CMake Gui tool and select the project source folder and a build directory and which version of Visual Studio you want to target.

After pressing the *Generate*  button, you can open the Visual Studio *.sln file generated in the build directory you have previously selected.
