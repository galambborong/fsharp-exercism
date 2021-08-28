module PhoneNumber

open System

let clean input =
    input
    |> String.filter Char.IsNumber
    |> UInt64.TryParse
