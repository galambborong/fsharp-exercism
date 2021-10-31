module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
        { direction = direction; position = position }

let directionsMap currentDirection currentPosition instruction =
    match currentDirection, currentPosition, instruction with
    | North, position, "R" -> { direction = East; position = position } 
    | North, position, "L" -> { direction = West; position = position }
    | North, (x, y), "A" -> { direction = currentDirection; position =  (x, y + 1)}
    | East, position, "R" -> { direction = South; position = position }
    | East, position, "L" -> { direction = North; position = position }
    | East, (x, y),"A" -> { direction = currentDirection; position = (x + 1, y) }
    | South, position, "R" -> { direction = West; position = position }
    | South, position, "L" -> {direction = East; position = position }
    | South, (x, y), "A" -> { direction = South; position = (x, y - 1)}
    | West, position, "R" -> {direction = North; position = position }
    | West, position, "L" -> { direction = South; position = position }
    | West, (x, y ), "A" -> {direction = currentDirection; position = (x - 1, y)}
    | _ -> failwith "todo"
     
let move (instructions: string) (robot: Robot) =
    let directions = instructions |> Seq.toList
    
    
    directions
    |> Seq.map (fun x -> directionsMap robot.direction robot.position (x.ToString()))
    
    // move "RA" (create Direction.North (0, 0))