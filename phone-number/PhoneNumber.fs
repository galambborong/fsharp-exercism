module PhoneNumber

open System

let parseToInt (nums: string) =
    match UInt64.TryParse nums with
    | true, x -> Ok x
    | _ -> Error "Unhandled failure"

let clean input =
    let nums = input |> String.filter Char.IsNumber
    let letters = input |> String.filter Char.IsLetter
    let punctuation = input |> String.filter (fun x -> x = '@' || x = ':' || x = '!')

    // TODO: Extract logic into clearly defined functions 
    match nums, letters, punctuation with
    | _, l, _ when l.Length > 0 -> Error "letters not permitted"
    | _, _, p when p.Length > 0 -> Error "punctuations not permitted"
    | n, _, _ when n.Length = 11 && n.[0] <> '1' -> Error "11 digits must start with 1"
    | n, _, _ when n.Length < 10 -> Error "incorrect number of digits"
    | n, _, _ when n.Length > 11 -> Error "more than 11 digits"
    | n, _, _ when n.StartsWith('0') || n.Length = 11 && n.[1] = '0' -> Error "area code cannot start with zero"
    | n, _, _ when n.Length <> 11 && n.[0] = '1' || n.Length = 11 && n.[1] = '1' -> Error "area code cannot start with one"
    | n, _, _ when n.Length = 10 && n.[3] = '0' || n.Length = 11 && n.[4] = '0' -> Error "exchange code cannot start with zero"
    | n, _, _ when n.Length = 10 && n.[3] = '1' || n.Length = 11 && n.[4] = '1' -> Error "exchange code cannot start with one"
    | n, _, _ when n.Length = 11 && n.[0] = '1' -> parseToInt (n.Substring(1, 10))
    | _ -> parseToInt nums
