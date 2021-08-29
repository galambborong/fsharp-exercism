module PhoneNumber

open System

let clean input =
    let res = input |> String.filter Char.IsNumber

    match UInt64.TryParse res with
    | true, x -> Ok x
    | _ -> Error "fail"
