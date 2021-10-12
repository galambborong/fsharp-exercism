module InterestIsInteresting

let interestRate balance =
    match balance with
    | x when x < 0m -> -3.213f
    | x when x < 1000m -> 0.5f
    | x when x < 5000m -> 1.621f
    | x when x >= 5000m -> 2.475f
    | _ -> failwith "N/A"

let annualBalanceUpdate balance =
    let interest = (interestRate balance |> decimal) / 100m
    balance + balance * interest


let amountToDonate balance (taxFreePercentage: float) =
    let taxFreeAsDecimal = taxFreePercentage |> decimal

    match balance with
    | x when x <= 0m -> 0
    | _ ->
        balance * (taxFreeAsDecimal / 100m)
        |> (*) 2m
        |> int