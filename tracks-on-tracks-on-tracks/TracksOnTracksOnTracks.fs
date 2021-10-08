module TracksOnTracksOnTracks

let newList: string list = []

let existingList = [ "F#"; "Clojure"; "Haskell" ]

let addLanguage language languagesList = language :: languagesList

let countLanguages (list: string list) = list.Length

let reverseList languages = languages |> List.rev

let excitingList languages =
    match languages, countLanguages languages with
    | _, c when c = 0 -> false
    | l, c when c = 1 || c > 3 ->
        match l.Head with
        | "F#" -> true
        | _ -> false
    | l, c when c < 4 ->
        match l.[0..1] with
        | l when l.Head = "F#" || l.[1] = "F#" -> true
        | _ -> false
    | _ -> false
