module DifferenceOfSquares

let square n = n * n

let squareOfSum number = [ 1 .. number ] |> List.sum |> square

let sumOfSquares number = [ 1 .. number ] |> List.sumBy square

let differenceOfSquares number =
    max (squareOfSum number) (sumOfSquares number)
    - min (squareOfSum number) (sumOfSquares number)
