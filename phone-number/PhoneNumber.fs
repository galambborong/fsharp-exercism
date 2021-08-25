module PhoneNumber

let strToNum (numbers: string) = uint64 numbers

// strToNum "0123"



let clean input =
    let numbers = input |> Seq.filter System.Char.IsNumber
    let bigNumAsString = numbers.ToString()



    match bigNumAsString.Length with
    | 10 -> strToNum bigNumAsString
    | _ -> strToNum bigNumAsString


let result = clean "(223) 456-7890"
