module Sieve

let primes n =
    let rec sievePrimes i list =
        match i < n with
        | true ->
            list
            |> List.filter (fun x -> i > x / 2 || x % i <> 0)
            |> sievePrimes (i + 1)
        | false -> list

    sievePrimes 2 [ 2 .. n ]
