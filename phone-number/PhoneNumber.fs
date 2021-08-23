module PhoneNumber

let strToNum numbers = int numbers



let clean (input: string) =
    let numbers = input |> Seq.filter System.Char.IsNumber
    let bigNumAsString = numbers.ToString()


    match bigNumAsString.Length with
    | 10 -> strToNum bigNumAsString
    | _ -> strToNum bigNumAsString
