module Tests

open System
open Xunit
open KatasSrc

[<Fact>]
let ``My test`` () =
    Assert.Equal("Hello You", Say.hello "World")
