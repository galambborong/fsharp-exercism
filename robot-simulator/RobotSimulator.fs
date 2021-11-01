module RobotSimulator

type Direction =
    | North
    | East
    | South
    | West

type Position = int * int

type Robot =
    { direction: Direction
      position: Position }

let create direction position =
    { direction = direction
      position = position }

let turnRight robot =
    match robot.direction with
    | North -> { robot with direction = East }
    | East -> { robot with direction = South }
    | West -> { robot with direction = North }
    | South -> { robot with direction = West }

let turnLeft robot =
    match robot.direction with
    | North -> { robot with direction = West }
    | East -> { robot with direction = North }
    | South -> { robot with direction = East }
    | West -> { robot with direction = South }

let advance robot =
    match robot.direction, robot.position with
    | North, (x, y) -> { robot with position = (x, y + 1) }
    | East, (x, y) -> { robot with position = (x + 1, y) }
    | South, (x, y) -> { robot with position = (x, y - 1) }
    | West, (x, y) -> { robot with position = (x - 1, y) }

let mapToDirectionOrPosition robot instruction =
    match instruction with
    | 'R' -> turnRight robot
    | 'L' -> turnLeft robot
    | 'A' -> advance robot
    | _ -> failwith "Invalid instruction"

let move instructions robot =
    instructions
    |> Seq.fold mapToDirectionOrPosition robot
