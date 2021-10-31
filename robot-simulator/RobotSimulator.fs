module RobotSimulator

open System.Net

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
        { direction = direction; position = position }

let directionsMap robot instruction =
    match robot.direction, robot.position, instruction with
    | North, _, "R" -> { robot with direction = East } 
    | North, _, "L" -> { robot with direction = West }
    | North, (x, y), "A" -> { robot with position =  (x, y + 1)}
    | East, _, "R" -> { robot with direction = South }
    | East, _, "L" -> { robot with direction = North }
    | East, (x, y),"A" -> { robot with position = (x + 1, y) }
    | South, _, "R" -> { robot with direction = West }
    | South, _, "L" -> { robot with direction = East }
    | South, (x, y), "A" -> { robot with position = (x, y - 1)}
    | West, _, "R" -> { robot with direction = North }
    | West, _, "L" -> { robot with direction = South }
    | West, (x, y ), "A" -> { robot with position = (x - 1, y)}
    | _ -> failwith "todo"
     
let move instructions robot =
    let directions = instructions |> Seq.toList |> List.map string
    
    directions
    |> Seq.fold directionsMap robot
