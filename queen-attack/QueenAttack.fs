module QueenAttack

let isValidBoardIndex x =
    x >= 0 && x < 8

let create (position: int * int) =
    isValidBoardIndex (fst position) && isValidBoardIndex (snd position)
    
let positionalDifference x y =
    max x y - min x y

let canAttack (queen1: int * int) (queen2: int * int) =
    let x1, y1 = queen1
    let x2, y2 = queen2
    match x1, y1, x2, y2 with
    | x1, _, x2, _ when x1 = x2 -> true 
    | _, y1, _, y2 when y1 = y2 -> true
    | x1, y1, x2, y2 when (positionalDifference x1 x2) = positionalDifference y1 y2 -> true
    | _ -> false
