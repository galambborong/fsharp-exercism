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
    let ageAsFloat = ageInSeconds |> float //|> (*) orbitalValue
    let earthYearInSeconds = 31557600.0
    let age = ageAsFloat / earthYearInSeconds
    Math.Round(age / orbitalValue, 2)



    // calculateAge 1000000000L 1.0
    // calculateAge 2134835688L 0.2408467
    // calculateAge 1210123456L 84.016846


let age (planet: Planet) (seconds: int64): float = failwith "You need to implement this function."