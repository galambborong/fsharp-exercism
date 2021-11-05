module TisburyTreasureHunt

let getCoordinate (_, coordinate) = coordinate

let convertCoordinate coordinate =
    let list =
        coordinate
        |> Seq.map string
        |> Seq.toList

    int list.Head, char list.[1]

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool =
    let aCoordinate = azarasData |> getCoordinate |> convertCoordinate
    let _, rCoordinate, _ = ruisData
    aCoordinate = rCoordinate

let createRecord
    (azarasData: string * string)
    (ruisData: string * (int * char) * string)
    : (string * string * string * string) =
    
    let r1, r2, r3 = ruisData
        
    match compareRecords azarasData ruisData with
    | true ->
        (snd azarasData, r1, r3, fst azarasData)
    | false ->
        ("", "", "", "")
