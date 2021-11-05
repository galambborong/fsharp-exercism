module TisburyTreasureHunt

let getCoordinate (_, coordinate) = coordinate

let convertCoordinate coordinate =
    let splitCoordinates =
        coordinate |> Seq.map string |> Seq.toList

    int splitCoordinates.[0], char splitCoordinates.[1]

let compareRecords azarasData ruisData =
    let azarasCoordinate =
        azarasData |> getCoordinate |> convertCoordinate

    let _, ruisCoordinate, _ = ruisData
    azarasCoordinate = ruisCoordinate

let createRecord azarasData ruisData =

    let treasure, coordinates = azarasData
    let location, _, quadrant = ruisData

    match compareRecords azarasData ruisData with
    | true -> coordinates, location, quadrant, treasure
    | false -> "", "", "", ""
