module Sieve

let isPrime n =
    let rec checkPrime i =
        i > n / 2 || (n % i <> 0 && checkPrime (i + 1))
    checkPrime 2

let primes limit =
    seq { for n in 2..limit do if isPrime n then n } |> Seq.toList