# dotnet core

## Installing and running

### Prerequisites

Get the latest dotnet core 1.1 version from the [dotnetcore website](https://www.microsoft.com/net/core).
Depending on what you run, you might want to download the command line tools only, VS Code or
VS 2017.

**Important**: if you use Visual Studio, the project is only compatible with VS 2017 and above.

### Using the projects

Build the solution (nuget packages should be restore automatically) and use Visual Studio's Test
explorer to run the tests. XUnit tests will show up automatically thanks to the `xunit.runner.visualstudio`
package.

The solution has been created using VS 2017 and is compatible with the Community Edition. It
is NOT compatible with VS 2015 editions or lower.

You can also use VSCode to write code and run unit tests, build and test tasks have been created.
To use them, press `ctrl+shift+p` and type `task build` or `task test`.

### dotnet watch

You can also setup a watch command to run the tests each time you modify a file.
To do so, open a command prompt in the `Kata.Tests` folder and run:

```bash
dotnet watch test
```

## Commands used to create this project

```bash
dotnet new console -n kata -f netcoreapp1.1
dotnet new xunit -n kata.tests -f netcoreapp1.1
dotnet new sln
```

## Solution Organization

### Kata Project

The Advanced folder contains some good old boilerplate code used to show examples
with the unit tests frameworks. The code ilustrates a typical Controller that takes
a service as dependency. The service itself uses a Generic Repository to perform
CRUD operations on a business entity.

The provided Unit Tests Projects show how to test this controller and mock its
dependencies.

*Note: a suggested kata is to rework this code to be CQRS.*

### XUnit

This project uses the XUnit test framework coupled with a few other popular library
that provide a BDD style testing capabilities.

Note: AutoFixture is not included since it is not supported yet on dotnet core.

Included packages:

* XUnit 2
* NSubstitute
* Fluent Assertions