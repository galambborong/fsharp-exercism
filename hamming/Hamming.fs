module Hamming

let distance (strand1: string) (strand2: string) =
    match strand1.Length = strand2.Length with
    | true ->
        Seq.map2 ((=)) strand1 strand2
        |> Seq.sumBy (fun isMatch ->
            if isMatch then 0 else 1)
        |> Some
    | false -> None
