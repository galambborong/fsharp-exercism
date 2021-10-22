module BirdWatcher

let lastWeek = [| 0; 2; 5; 3; 7; 8; 4 |]

let yesterday (counts: int []) = counts.[5]

let total (counts: int []) = counts |> Array.sum

let dayWithoutBirds (counts: int []) = counts |> Array.contains 0

let incrementTodaysCount (counts: int []) =
    counts.[6] <- (counts.[6] + 1)
    counts

let oddWeek (counts: int []) =
    match counts with
    | [| 5; _; 5; _; 5; _; 5 |]
    | [| _; 0; _; 0; _; 0; _ |]
    | [| _; 10; _; 10; _; 10; _ |] -> true
    | _ -> false
