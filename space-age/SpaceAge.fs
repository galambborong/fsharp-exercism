module SpaceAge

open System

type Planet =
    | Mercury
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let calculateAge (ageInSeconds: int64) (orbitalValue: float) =
    let age1 = ageInSeconds |> float |> (*) orbitalValue
    let yearInSeconds = 31557600.0
    Math.Round(age1 / yearInSeconds, 2)
    
    // calculateAge 1000000000L 1.0
    // calculateAge 2134835688L 0.2408467
    

let age (planet: Planet) (seconds: int64): float = failwith "You need to implement this function."