module Pangram

let isPangram (input: string): bool =
    match input <> "" with
    | true -> true
    | false -> input.Contains("abcx")