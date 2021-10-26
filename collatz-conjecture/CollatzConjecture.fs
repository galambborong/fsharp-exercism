module CollatzConjecture

let rec collatzConjecture (n, x) =
    match n with
    | n when n > 1 ->
        match n % 2 with
        | 0 -> collatzConjecture (n / 2, x + 1)
        | _ -> collatzConjecture (n * 3 + 1, x + 1)
    | n when n = 1 -> Some x
    | _ -> None

let steps number = collatzConjecture (number, 0)
