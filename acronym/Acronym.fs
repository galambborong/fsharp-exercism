module Acronym

let isLetter = String.filter System.Char.IsLetter
let getFirstChar (x: string) = x.Substring(0, 1).ToUpper()
let transform = isLetter >> getFirstChar

let abbreviate (phrase: string) =
    phrase.Split(" ")
    |> Array.map (fun (x: string) -> x.Split("-"))
    |> Seq.concat
    |> Seq.filter (fun x -> x.Length <> 0)
    |> Seq.map transform
    |> String.concat ""