module ReverseString

let reverse (input: string) =
    input
    |> Seq.indexed
    |> Seq.iter (fun x -> printfn $"{x}")
    
    
// reverse "robot"
