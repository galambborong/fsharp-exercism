module Isogram

let countUniqueChars (str: string) = str.ToLower() |> Set.ofSeq |> Set.count

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
    let uniqueChars = countUniqueChars str

    match uniqueChars with
    | uniqueChars when stringLength = uniqueChars -> true
    | uniqueChars when uniqueChars + whiteSpacesOrDashes - 1 = stringLength -> true
    | _ -> false
