module GuessingGame

let reply guess =
    match guess with
    | 42 -> "Correct"
    | 41 | 43 -> "So close"
    | x when x < 41 -> "Too low"
    | x when x > 43 -> "Too high"
    | _ -> failwith "This pattern should not be required"
