module Pangram

let alphabet = "abcdefghijklmnopqrstuvwxyz" |> Set

let standardiseInput (string: string) =
    string.Trim().ToLower()
    |> Seq.filter System.Char.IsLetter
    |> Set.ofSeq

let isPangram (input: string) = standardiseInput input = alphabet
