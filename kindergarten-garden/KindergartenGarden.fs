module KindergartenGarden

type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets

let mapPlant x =
      match x with
      | "R" -> Plant.Radishes
      | "C" -> Plant.Clover
      | "G" -> Plant.Grass
      | "V" -> Plant.Violets
      
let plants (diagram: string) student =
    diagram.Split('\n')