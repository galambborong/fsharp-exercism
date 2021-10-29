module RobotSimulator

open Microsoft.FSharp.Reflection

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
        { direction = direction; position = position }

let move instructions (robot: Robot) =

    let nextDirection =
        FSharpType.GetUnionCases typeof<Direction>
        |> Array.toList
        |> List.indexed

    match instructions with
    | "R" -> { direction = Direction. ; position = robot.position }
    | _ -> failwith "todo"