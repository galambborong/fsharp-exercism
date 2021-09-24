module KindergartenGarden

type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets

let mapPlant x =
      match x with
      | 'R' -> Plant.Radishes
      | 'C' -> Plant.Clover
      | 'G' -> Plant.Grass
      | 'V' -> Plant.Violets
      | _ -> failwith "todo"

let mapOwner name =
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

let transformStringToRows (input: string) =
    input.Split('\n')
    |> Array.toSeq
    |> Seq.map List.ofSeq
    
let plants diagram student =
    let rows = diagram |> transformStringToRows
    let owner = mapOwner student

    let secondRow =
        rows
        |> Seq.last
        |> List.map mapPlant

    let firstRow =
        rows
        |> Seq.head
        |> List.map mapPlant

    secondRow.[owner..owner + 1]
    |> List.append firstRow.[owner..owner + 1]