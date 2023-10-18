module Tests

open FsUnit.Xunit
open Kata
open Xunit

[<Fact>]
let ``Hello test using Xunit`` () =
    Assert.Equal("Hello You", Say.hello "World")

[<Fact>]
let ``Hello world using FsUnit assertion library`` () =
    Say.hello "World"
    |> should equal "Hello You" 
