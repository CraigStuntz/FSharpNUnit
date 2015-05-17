module TreeTests

open NUnit.Framework
open FsUnit
open Tree

[<Test>]
let ``Count of simple tree`` () = 
    Branch [ Branch [ Leaf 1; Leaf 2]; Branch [Leaf 3]] |> Tree.leafCount |> should equal 3