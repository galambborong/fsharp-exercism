module Leap

let leapYear year =
    match year with
    | year when year % 4 = 0 && year % 100 <> 0 -> true
    | year when year % 400 = 0 -> true
    | _ -> false

