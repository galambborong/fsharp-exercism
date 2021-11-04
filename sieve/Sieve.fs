module Sieve

let isPrime n =
    let rec checkFactors i =
        i > n / 2 || n % i <> 0 && checkFactors (i + 1)

    checkFactors 2

let primes limit = [ 2 .. limit ] |> List.filter isPrime
