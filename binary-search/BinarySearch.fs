module BinarySearch

open System

let x = [|1;2;3|]

let calculateHalf i = Math.Floor(i / 2 |> float) |> int

let find (input: int[]) (value: int) =
    let n = input.Length
    let i = calculateHalf n
    let x = value
    
    let rec checkIndex i x =
        match input.[i] with
        | idx when idx = x -> Some i
        | idx when idx > x ->
            let nextI = calculateHalf i
            match nextI with
            | idx when idx < 0 -> None
            | _ -> checkIndex nextI x
        | idx when idx < x ->
            let nextI = calculateHalf i
            match nextI, n with
            | idx, n when idx < n -> None
            | idx, n when (idx + i) > n -> None
            | _ -> checkIndex (i + nextI) x
        | _ -> None
    
    match input |> Array.isEmpty with
    | true -> None
    | false -> checkIndex i x
        
// find [|1; 2; 3|] 2
// find [|6|] 6
    
        
    
    