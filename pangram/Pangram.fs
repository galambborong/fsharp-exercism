module Pangram

let alphabet =
    "abcdefghijklmnopqrstuvwxyz".ToCharArray()

let standardiseInput (string: string) =
    string.Trim().ToLower()
    |> Seq.sort
    |> Seq.filter (fun x -> x.ToString() <> " ")
    |> Array.ofSeq

let isPangram (input: string) : bool =
    match input <> "" with
    | true -> true
    | false -> standardiseInput input = alphabet
