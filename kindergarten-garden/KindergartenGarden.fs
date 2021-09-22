﻿module KindergartenGarden

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
      
      
// plants "RC\nGG" "Alice"
// plants "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV" "Alice"
      
let plants (diagram: string) (student: string) =
    diagram.Split('\n')
    |> Array.toSeq
    |> Seq.map List.ofSeq
//    |> Seq.map (fun x -> Seq.map mapPlant)