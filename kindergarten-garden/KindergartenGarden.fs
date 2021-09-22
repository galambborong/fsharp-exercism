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
    diagram |> transformInput |> Seq.head |> List.map mapPlant

// plants "RC\nGG" "Alice"

let plants' (diagram: string) (student: string) =
    diagram |> List.ofSeq