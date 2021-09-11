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
    | false, false, _, true -> true
    | false, false, true, false -> true
    | true, false, _, true -> true
    | _ -> false
