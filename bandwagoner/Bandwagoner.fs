module Bandwagoner

type Coach = { Name: string; FormerPlayer: bool }

type Stats = { Wins: int; Losses: int }

type Team =
    { Name: string
      Coach: Coach
      Stats: Stats }

let createCoach name formerPlayer =
    { Name = name
      FormerPlayer = formerPlayer }

let createStats wins losses = { Wins = wins; Losses = losses }

let createTeam name coach stats =
    { Name = name
      Coach = coach
      Stats = stats }

let replaceCoach team coach =
    let newTeam = { team with Coach = coach }
    newTeam

let isSameTeam homeTeam awayTeam = homeTeam = awayTeam

let rootForTeam team =
    let { Coach = coachName
          Stats = stats
          Name = teamName } =
        team

    let { Wins = wins; Losses = losses } = stats

    match coachName, teamName with
    | { Name = "Gregg Popovich" }, _
    | { FormerPlayer = true }, _
    | _, "Chicago Bulls" -> true
    | _ ->
        match wins, losses with
        | wins, _ when wins >= 60 -> true
        | wins, losses when losses > wins -> true
        | _ -> false
