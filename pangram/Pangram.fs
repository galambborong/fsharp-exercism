module Pangram

let alphabet = "abcdefghijklmnopqrstuvwxyz" |> Set

let standardiseInput (str: string) =
    str.ToLower()
    |> Seq.filter System.Char.IsLetter
    |> Set.ofSeq

let isPangram input = standardiseInput input = alphabet
