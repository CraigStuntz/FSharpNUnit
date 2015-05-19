module ExpressionTests

open NUnit.Framework
open FsUnit
open Expression

[<Test>]
let ``Value of simple example`` () = 
    value <| Sum (Constant 1, (Sum (Constant 2, Constant 3))) |> should equal 6