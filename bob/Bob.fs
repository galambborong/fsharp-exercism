module Bob

let response (input: string): string =
    let trimmedMessage =  input.Trim()
    let isQuestion = trimmedMessage.EndsWith('?')
    let isShouting = trimmedMessage = trimmedMessage.ToUpper() && trimmedMessage.Length <> 0
    let isEmpty = trimmedMessage.Equals("")
    
    match isEmpty, isQuestion, isShouting with
    | true, false, false -> "Fine. Be that way!"
    | false, true, false -> "Sure."
    | false, false, true -> "Whoa, chill out!"
    | false, true, true -> "Calm down, I know what I'm doing!"
    | _ -> "Whatever."