module QueenAttack

let isValidBoardIndex x =
    [0..7] |> List.contains x

let create (position: int * int) =
    isValidBoardIndex (fst position) && isValidBoardIndex (snd position)
    
let isSameRowOrColumn x y = x = y
    
let positionalDifference x y = max x y - min x y

let isDiagonal (x, y) (a, b) =
    positionalDifference x a = positionalDifference y b

let canAttack (queen1: int * int) (queen2: int * int) =
    match queen1, queen2 with
    | (x1, _), (x2, _) when isSameRowOrColumn x1 x2 -> true 
    | (_, y1), (_, y2) when isSameRowOrColumn y1 y2 -> true
    | (x1, y1), (x2, y2) when positionalDifference x1 x2 = positionalDifference y1 y2 -> true
    | _ -> false
