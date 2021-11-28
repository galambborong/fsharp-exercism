module BinarySearch

open System

let calculateHalf i = Math.Floor(i / 2 |> float) |> int

let find (input: int[]) (value: int) =
    let length = input.Length
    printfn $"length = {length}"
    let initialIndex = calculateHalf length
    printfn $"half of length = {initialIndex}"
    
    let rec checkIndex i x =
        printf $"i: {i} :: x: {x}\n"
        printf $"value at index {i} = {input.[i]}\n"
        printf $"input.[i] = x: {input.[i] = x}\n\n"
        
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
            | nextI when (nextI + i) = initialIndex -> checkIndex (i + nextI - 1) x
//            | nextI when (nextI + i) > length -> None
            | _ -> checkIndex (i + nextI) x
        | _ -> None 
    
    match input |> Array.isEmpty with
    | true -> None
    | false ->
        match input.[0], input.[input.Length - 1] with
        | y, _ when y > value -> None
        | _, y when y < value -> None
        | _ -> checkIndex initialIndex value
        
// find [|1; 2; 3|] 2
// find [|6|] 6

// find [|1;3;4;6;8;9;11|] 11
// find [|1;3;4;6;8;9;11|] 6
// find [|1;3;4;6;8;9;11|] 1
// find [|1; 3; 5; 8; 13; 21; 34; 55; 89; 144; 233; 377|] 21
// find [|1; 3; 5; 8; 9; 11|] 0
    
        
    
    