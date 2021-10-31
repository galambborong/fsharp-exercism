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

let mapToDirectionOrPosition robot instruction =
    match robot.direction, robot.position, instruction with
    | North, _, 'R' -> { robot with direction = East }
    | North, _, 'L' -> { robot with direction = West }
    | East, _, 'R' -> { robot with direction = South }
    | East, _, 'L' -> { robot with direction = North }
    | South, _, 'R' -> { robot with direction = West }
    | South, _, 'L' -> { robot with direction = East }
    | West, _, 'R' -> { robot with direction = North }
    | West, _, 'L' -> { robot with direction = South }
    | North, (x, y), 'A' -> { robot with position = (x, y + 1) }
    | East, (x, y), 'A' -> { robot with position = (x + 1, y) }
    | South, (x, y), 'A' -> { robot with position = (x, y - 1) }
    | West, (x, y), 'A' -> { robot with position = (x - 1, y) }
    | _ -> failwith "Invalid input"

let move instructions robot =
    instructions
    |> Seq.toList
    |> Seq.fold mapToDirectionOrPosition robot
