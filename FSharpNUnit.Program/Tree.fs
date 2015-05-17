module Tree

type Tree<'a> = 
    | Leaf of 'a
    | Branch of List<Tree<'a>>

let rec leafCount = function
| Leaf _ -> 1
| Branch branches -> branches |> List.map leafCount |> List.sum

let ofList list = Branch list

let rec toSeq node = 
    seq { 
        match node with
        | Leaf value -> yield value
        | Branch branches -> 
            for branch in branches do yield! toSeq branch
    }
