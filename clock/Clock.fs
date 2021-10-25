module Clock

open System

let handleOverClocking hours =
    match hours > 24 with
    | true -> hours % 24
    | false -> hours

let create (hours: int) (minutes: int) =
    TimeSpan(handleOverClocking hours, minutes, 0).TotalSeconds

let add minutes (clock: float) =
    clock + TimeSpan(0, minutes, 0).TotalSeconds

let subtract minutes clock =
    clock - TimeSpan(0, minutes, 0).TotalSeconds

let realDisplay timeSpan = timeSpan.ToString().Substring(0, 5)

let anotherDisplay timeSpan = timeSpan.ToString().Substring(2, 5)

let display (clock: float) =
    let time = TimeSpan.FromSeconds(clock)

    match time.Days with
    | 0 -> realDisplay time
    | _ -> anotherDisplay time
