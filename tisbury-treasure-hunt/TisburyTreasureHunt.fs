module TisburyTreasureHunt

let getCoordinate (_, coordinate) = coordinate

let convertCoordinate coordinate =
    let list =
        coordinate
        |> Seq.map string
        |> Seq.toList

    int list.Head, char list.[1]

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool =
    failwith "Please implement the 'compareRecords' function"

let createRecord
    (azarasData: string * string)
    (ruisData: string * (int * char) * string)
    : (string * string * string * string) =
    failwith "Please implement the 'createRecord' function"
