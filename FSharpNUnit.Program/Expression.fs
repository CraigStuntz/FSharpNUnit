module Expression

type Expression = 
    | Constant of int
    | Sum of Expression * Expression

let rec value = function
| Constant i -> i
| Sum (left, right) -> (value left) + (value right)
