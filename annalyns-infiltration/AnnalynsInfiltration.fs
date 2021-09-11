module AnnalynsInfiltration

let canFastAttack knightIsAwake =
    match knightIsAwake with
    | true -> false
    | false -> true

let canSpy knightIsAwake archerIsAwake prisonerIsAwake =
    match knightIsAwake, archerIsAwake, prisonerIsAwake with
    | false, false, false -> false
    | _ -> true
    

let canSignalPrisoner(archerIsAwake: bool) (prisonerIsAwake: bool): bool =
   failwith "Please implement the 'canSignalPrisoner' function"

let canFreePrisoner(knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
 failwith "Please implement the 'canFreePrisoner' function"
