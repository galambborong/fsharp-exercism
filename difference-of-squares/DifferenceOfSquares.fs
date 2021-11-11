module DifferenceOfSquares

let multiplyBySelf n = n * n

let squareOfSum number =
    [1..number]
    |> List.sum
    |> multiplyBySelf

let sumOfSquares number =
    [1..number]
    |> List.sumBy multiplyBySelf

let differenceOfSquares number =
    max (squareOfSum number) (sumOfSquares number) - min (squareOfSum number) (sumOfSquares number)