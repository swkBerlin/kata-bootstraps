# FSharp dotnet core 5 template

## Initial template project setup

```sh
dotnet new classlib -n Kata -lang f#
dotnet new xunit -n Kata.Tests -lang f#
dotnet new sln
dotnet sln add Kata Kata.Tests
```

Additional Libs: 

- `FsUnit.Xunit` (optional): f# assertion lib

