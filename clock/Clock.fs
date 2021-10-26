module Clock

open System

let totalMinutesPerDay = TimeSpan(1, 0, 0, 0).TotalMinutes

let numberOfMinutes minutes = TimeSpan(0, minutes, 0).TotalMinutes

let displayNormalTime timeSpan = timeSpan.ToString().Substring(0, 5)

let displayTimeOver24Hrs timeSpan = timeSpan.ToString().Substring(2, 5)

let handleOverHours hours =
    match hours with
    | h when h > 24 -> hours % 24
    | h when h < 24 -> hours
    | h when h = 24 -> 0
    | _ -> failwith "This case should never appear"

let rec handleNegativeMinuteCount minutes =
    match minutes < 0.0 with
    | true -> handleNegativeMinuteCount (minutes + totalMinutesPerDay)
    | false -> minutes

let rec handleExcessMinutes minutes hours =
    match minutes > 60 with
    | true -> handleExcessMinutes (minutes - 60) (hours + 1)
    | false -> hours, minutes

let create hours minutes =
    TimeSpan(
        handleOverHours (fst (handleExcessMinutes minutes hours)),
        snd (handleExcessMinutes minutes hours),
        0
    )
        .TotalMinutes
    |> handleNegativeMinuteCount

let add minutesToAdd currentTotalMinutes =
    currentTotalMinutes
    |> (+) (numberOfMinutes minutesToAdd)

let subtract minutesToSubtract currentTotalMinutes =
    let temporaryMinuteCount =
        currentTotalMinutes
        |> (-) (numberOfMinutes minutesToSubtract)

    match temporaryMinuteCount < 0.0 with
    | true -> handleNegativeMinuteCount temporaryMinuteCount
    | false -> temporaryMinuteCount

let display clock =
    let time =
        clock
        |> handleNegativeMinuteCount
        |> TimeSpan.FromMinutes

    match time.Days with
    | 0 -> displayNormalTime time
    | _ -> displayTimeOver24Hrs time
