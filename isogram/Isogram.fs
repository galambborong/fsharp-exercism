module Isogram

let countUniqueLetters (str: string) =
    str.ToLower()
    |> Seq.filter System.Char.IsLetter
    |> Set.ofSeq
    |> Set.count

let countAllowedChars str =
    str
    |> Seq.sumBy
        (fun char ->
            if char = ' ' || char = '-' then
                1
            else
                0)

let isIsogram (str: string) =
    let stringLength = str.Length
    let whiteSpacesOrDashes = countAllowedChars str
    let uniqueLetters = countUniqueLetters str

    match uniqueLetters with
    | uniqueLetters when stringLength = uniqueLetters -> true
    | uniqueLetters when uniqueLetters + whiteSpacesOrDashes = stringLength -> true
    | _ -> false
