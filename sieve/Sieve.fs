module Sieve

let isPrime n =
    let rec checkFactors i =
        i > n / 2 || n % i <> 0 && checkFactors (i + 1)

    checkFactors 2

let primes' limit = [ 2 .. limit ] |> List.filter isPrime

let primes n =
    let rec sievePrimes list i =
        if i < n then
            list
            |> List.filter (fun x -> i > x / 2 || x % i <> 0)
        else
            sievePrimes list (i + 1)
    
    sievePrimes [2..n] 2
    
        // primes 10
        
        // primes' 13