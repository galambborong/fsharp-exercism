module RobotSimulator

open Microsoft.FSharp.Reflection

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
        { direction = direction; position = position }

let nextDirection currentDirection instruction =
    match currentDirection, instruction with
    | Direction.North, "R" -> Direction.East
    | Direction.North, "L" -> Direction.West
    | Direction.North, "A" -> Direction.North
    | Direction.East, "R" -> Direction.South
    | Direction.East, "L" -> Direction.North
    | Direction.East, "A" -> Direction.East
    | _ -> failwith "todo"

let move instructions (robot: Robot) =
    
    let directionUpdate = nextDirection robot.direction instructions
    
    { robot with direction = directionUpdate }
