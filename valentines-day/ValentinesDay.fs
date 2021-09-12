module ValentinesDay

type Approval =
    | Yes
    | No
    | Maybe

type Cuisine =
    | Turkish
    | Korean

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity activity =
    match activity with
    | Movie Romance -> Yes
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> Yes
        | Turkish -> Maybe
    | Walk km ->
        match km with
        | n when n < 3 -> Yes
        | n when n < 5 -> Maybe
        | _ -> No
    | _ -> No
