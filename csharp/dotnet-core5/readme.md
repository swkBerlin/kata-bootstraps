# dotnet core 5 template

## Initial Setup

```sh
dotnet new classlib -n Kata
dotnet new xunit -n Kata.Tests
dotnet new sln
dotnet sln add Kata Kata.Tests
cd Kata.Tests
dotnet add reference ../Kata
dotnet add package FluentAssertions NSubstitute
cd ..
```

The following command should run all tests:

```sh
dotnet test
```

