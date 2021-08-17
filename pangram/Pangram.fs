module Pangram

let alphabet = "abcdefghijklmnopqrstuvwxyz"

let handleStringFormatting (string: string) =
    string.Trim().ToLower()
//    |> string.Split
    |> Seq.sort
    |> Seq.filter (fun (x) -> x.ToString() <> " ")
    |> Seq.toList

let isPangram (input: string): bool =
    match input <> "" with
    | true -> true