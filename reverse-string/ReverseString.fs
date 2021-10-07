module ReverseString

let reverse input =
    input
    |> Seq.rev
    |> Seq.map string
    |> String.concat ""