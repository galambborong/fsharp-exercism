module Acronym

let isLetter = String.filter System.Char.IsLetter
let getFirstCharAndCapitalise (x: string) = x.Substring(0, 1).ToUpper()
let transform = isLetter >> getFirstCharAndCapitalise

let abbreviate (phrase: string) =
    phrase.Split(" ")
    |> Array.collect (fun (x: string) -> x.Split("-"))
    |> Array.filter (fun x -> x.Length <> 0)
    |> Array.map transform
    |> String.concat ""
