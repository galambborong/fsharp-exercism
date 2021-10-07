module ReverseString

let reverse (input: string) =
    input
    |> Seq.rev
    |> Seq.map string
    |> String.concat ""