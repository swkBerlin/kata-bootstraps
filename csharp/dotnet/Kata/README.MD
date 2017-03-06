# CSharp

## Installing and running

Build the solution (nuget packages should be restore automatically) and use Visual Studio's Test
explorer to run the tests. XUnit tests will show up automatically thanks to the `xunit.runner.visualstudio`
package.

The unit tests can also be run using ReSharper's test runner.

The solution has been created using VS 2015 and is compatible with the Community Edition.
It is also compatible with VS 2017 Community.

## Solution Organization

### Kata Project

The Advanced folder contains some good old boilerplate code used to show examples
with the unit tests frameworks. The code ilustrates a typical Controller that takes
a service as dependency. The service itself uses a Generic Repository to perform
CRUD operations on a business entity.

The provided Unit Tests Projects show how to test this controller and mock its
dependencies.

*Note: a suggested kata is to rework this code to be CQRS.*

### MSTEST

This project is bare-bone MS Test project with MoQ. It is easy to use but will
require to write lengthy Arrange sections in unit tests.

Included packages:

* MSTest
* MoQ

### XUnit (Recommended)

This project uses more advanced unit testing frameworks and techniques.
The test runner is XUnit, which uses its extensibility to provide AutoMocking
using AutoFixture through the `AutoData` attributes. A custom `AutoData` attribute
is included to allow auto-mocking of dependencies using NSubstitute, as well as
creating objects with dummy values.

Using the `[Frozen]` attributes on theories' parameters allows them to be instantiated
as singleton within the unit test's scope. Use it if you need to setup/verify a Mock for
example.

This project also uses Fluent Assertions, which provide a fluent API to write assertions
and help making your tests more DAMP.

Included packages:

* XUnit 2
* NSubstitute
* Fluent Assertions
* AutoFixture