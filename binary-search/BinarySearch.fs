module BinarySearch

open System

let x = [|1;2;3|]

let calculateHalf i = Math.Floor(i / 2 |> float) |> int

let find (input: int[]) (value: int) =
    let length = input.Length
    let initialIndex = calculateHalf length
    
    let rec checkIndex i x =
        printf $"i: {i} :: x: {x}\n"
        printf $"value at index {i} = {input.[i]}\n"
        printf $"{input.[i] = x}\n"
        
        // TODO We need to confirm that the next index +/- has been checked already
        
        match input.[i] with
        | valueAtIndex when valueAtIndex = x -> Some i
        | valueAtIndex when valueAtIndex > x ->
            let nextI = calculateHalf i
            match nextI with
            | nextI when nextI < 0 -> None
            | _ -> checkIndex nextI x
        | valueAtIndex when valueAtIndex < x ->
            let nextI = calculateHalf i
            match nextI with
//            | nextI when nextI > length -> None
            | nextI when (nextI + i) > length -> None
            | _ -> checkIndex (i + nextI) x
        | _ -> None 
    
    match input |> Array.isEmpty with
    | true -> None
    | false -> checkIndex initialIndex value
        
// find [|1; 2; 3|] 2
// find [|6|] 6

// find [|1;3;4;6;8;9;11|] 11
    
        
    
    