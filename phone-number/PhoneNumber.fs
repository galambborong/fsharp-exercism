module PhoneNumber

open System

let clean input =
    input
    |> Seq.filter Char.IsNumber
    |> Seq.map string
    |> String.concat ""
    |> uint64
    |> Ok
