module AnnalynsInfiltration

let canFastAttack knightIsAwake =
    match knightIsAwake with
    | true -> false
    | false -> true

let canSpy knightIsAwake archerIsAwake prisonerIsAwake =
    match knightIsAwake, archerIsAwake, prisonerIsAwake with
    | false, false, false -> false
    | _ -> true
    

let canSignalPrisoner archerIsAwake prisonerIsAwake =
    match archerIsAwake, prisonerIsAwake with
    | false, true -> true
    | _ -> false

let canFreePrisoner knightIsAwake archerIsAwake prisonerIsAwake petDogIsPresent =
    match knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent with
    | true, true, true, _ -> false
    | false, true, true, _ -> false
    | true, false, true, false -> false
    | _, _, true, _ -> true
    | _, _, _, false -> false
    | _, false, _, true -> true
    | _, true, _, true -> false
