module KindergartenGarden

type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets


let mapPlant (x:char) =
      match x with
      | 'R' -> Plant.Radishes
      | 'C' -> Plant.Clover
      | 'G' -> Plant.Grass
      | 'V' -> Plant.Violets
      | _ -> failwith "todo"


// plants' "RC\nGG" "Alice"
// plants "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV" "Alice"

let transformInput (input: string) =
    input.Split('\n')
    |> Array.toSeq
    |> Seq.map List.ofSeq

//  transformInput "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"

let plants (diagram: string) (student: string) =
    let thing = diagram |> transformInput

    let tail =
        thing
        |> Seq.last
        |> List.map mapPlant

    let head =
        thing
        |> Seq.head
        |> List.map mapPlant

    tail
    |> List.append head


// plants "RC\nGG" "Alice"

let plants' (diagram: string) (student: string) =
    diagram |> List.ofSeq