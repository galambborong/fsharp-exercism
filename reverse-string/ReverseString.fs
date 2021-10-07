module ReverseString

let reverse (input: string) =
    input
    |> Seq.rev
    |> Seq.map string//(fun x -> x.ToString())
    |> String.concat ""