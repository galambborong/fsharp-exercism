module CarsAssemble

let productionRatePerHour speed =
    let productionWithNoFaults = speed * 221 |> float
    match speed with
    | x when x < 5 -> productionWithNoFaults
    | x when x < 9 -> productionWithNoFaults * 0.9
    | x when x = 9 -> productionWithNoFaults * 0.8
    | x when x = 10 -> productionWithNoFaults * 0.77
    | _ -> failwith "Number not on the scale"

let workingItemsPerMinute speed =
    let prodRatePerHour = productionRatePerHour speed |> int
    prodRatePerHour / 60