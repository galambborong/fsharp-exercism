module QueenAttack

let isValidBoardIndex x = [ 0 .. 7 ] |> List.contains x

let create (position: int * int) =
    isValidBoardIndex (fst position)
    && isValidBoardIndex (snd position)

let isSameRowOrColumn x y = x = y

let positionalDifference x y = max x y - min x y

let isDiagonal (x, y) (a, b) =
    positionalDifference x a = positionalDifference y b

let canAttack (queen1: int * int) (queen2: int * int) =
    match queen1, queen2 with
    | (q1, _), (q2, _) when isSameRowOrColumn q1 q2 -> true
    | (_, q1), (_, q2) when isSameRowOrColumn q1 q2 -> true
    | queen1, queen2 -> isDiagonal queen1 queen2
    | _ -> false
