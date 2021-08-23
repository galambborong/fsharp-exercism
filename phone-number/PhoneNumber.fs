module PhoneNumber

let clean (input:string) =
    input
    |> Seq.filter System.Char.IsNumber
    
    
    