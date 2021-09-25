module KindergartenGarden

type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets

let getPlantType x =
      match x with
      | 'R' -> Plant.Radishes
      | 'C' -> Plant.Clover
      | 'G' -> Plant.Grass
      | 'V' -> Plant.Violets
      | _ -> failwith "todo"

let getOwnerSeatPosition name =
    match name with
    | "Alice" -> 0
    | "Bob" -> 2
    | "Charlie" -> 4
    | "David" -> 6
    | "Eve" -> 8
    | "Fred" -> 10
    | "Ginny" -> 12
    | "Harriet" -> 14
    | "Ileana" -> 16
    | "Joseph" -> 18
    | "Kincaid" -> 20
    | "Larry" -> 22
    | _ -> failwith "todo"

let transformStringIntoRows (input: string) =
    input.Split('\n')
    |> Array.toList
    |> List.map List.ofSeq
    
let transformToPlants row =
    row |> List.map getPlantType
    
let plants diagram student =
    let ownerPosition = getOwnerSeatPosition student
    diagram
    |> transformStringIntoRows
    |> List.map (fun row -> row.[ownerPosition..ownerPosition + 1])
    |> List.concat
    |> transformToPlants
