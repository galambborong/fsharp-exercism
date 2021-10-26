module Clock

open System

let handleOverHours hours =
    match hours > 24 with
    | true -> hours % 24
    | false -> hours
    
let rec handleOverMinutes minutes hours =
    match minutes > 60 with
    | true ->
        handleOverMinutes (minutes - 60) (hours + 1)
    | false -> hours, minutes

let create (hours: int) (minutes: int) =
    let mins = handleOverMinutes minutes hours
    TimeSpan(handleOverHours (fst mins), snd mins, 0).TotalMinutes

let add minutes (clock: float) =
    clock + TimeSpan(0, minutes, 0).TotalMinutes

let subtract minutes clock =
    match minutes, clock with
    | min, clk when (float min) < clk -> 
        clock - TimeSpan(0, minutes, 0).TotalMinutes
    | min, clk when (float min) > clk ->
        let tmp = handleOverMinutes min 0
        TimeSpan(1, 0, 0, 0, 0).TotalMinutes - (TimeSpan((fst tmp), (snd tmp), 0).TotalMinutes - clock)
    | _ -> failwith "todo"

let realDisplay timeSpan = timeSpan.ToString().Substring(0, 5)

let anotherDisplay timeSpan = timeSpan.ToString().Substring(2, 5)

let display (clock: float) =
    let time = TimeSpan.FromMinutes(clock)

    match time.Days with
    | 0 -> realDisplay time
    | _ -> anotherDisplay time
