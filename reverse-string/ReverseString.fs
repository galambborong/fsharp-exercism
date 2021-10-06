module ReverseString

let reverse (input: string): string =
    let rec loop acc = function
        | [] -> acc
        | x :: xs -> loop (x :: xs) tail
    loop [] input.
