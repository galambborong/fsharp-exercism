module Clock

open System

let handleOverHours hours =
    match hours with
    | h when h > 24 -> hours % 24
    | h when h < 24 -> hours
    | h when h = 24 -> 0
    | _ -> failwith "todo"
    
let rec handleNegatives mins =
    match mins < 0.0 with
    | true -> handleNegatives (mins + TimeSpan(1, 0, 0, 0).TotalMinutes)
    | false -> mins
    
let rec handleOverMinutes minutes hours =
    match minutes > 60 with
    | true ->
        handleOverMinutes (minutes - 60) (hours + 1)
    | false -> hours, minutes

let create (hours: int) (minutes: int) =
    let mins = handleOverMinutes minutes hours
    let x = TimeSpan(handleOverHours (fst mins), snd mins, 0).TotalMinutes
    x
    |> handleNegatives

let add minutes (clock: float) =
    clock + TimeSpan(0, minutes, 0).TotalMinutes



let subtract minutes clock =
    let tmp = clock - TimeSpan(0, minutes, 0).TotalMinutes
    match tmp < 0.0 with
    | true -> handleNegatives tmp
    | false -> tmp

let realDisplay timeSpan = timeSpan.ToString().Substring(0, 5)

let anotherDisplay timeSpan = timeSpan.ToString().Substring(2, 5)

let display (clock: float) =
    let time = clock |> handleNegatives |> TimeSpan.FromMinutes

    match time.Days with
    | 0 -> realDisplay time
    | _ -> anotherDisplay time
