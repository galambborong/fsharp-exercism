module BeerSong

let standardVerse n =
    [ $"{n} bottles of beer on the wall, {n} bottles of beer."
      $"Take one down and pass it around, {n - 1} bottles of beer on the wall." ]

let twoBottleVerse =
    [ "2 bottles of beer on the wall, 2 bottles of beer."
      "Take one down and pass it around, 1 bottle of beer on the wall." ]


let oneBottleVerse =
    [ "1 bottle of beer on the wall, 1 bottle of beer."
      "Take it down and pass it around, no more bottles of beer on the wall." ]

let noBottleVerse =
    [ "No more bottles of beer on the wall, no more bottles of beer."
      "Go to the store and buy some more, 99 bottles of beer on the wall." ]

let recite startBottles takeDown =
    let rec buildVerses verses currentNumber versesToGo =
        let updatedVerse =
            match currentNumber with
            | x when x > 2 -> standardVerse x
            | 2 -> twoBottleVerse
            | 1 -> oneBottleVerse
            | 0 -> noBottleVerse
            | _ -> failwith "This case should never occur"
            |> List.append [ "" ]
            |> List.append verses

        match currentNumber, versesToGo with
        | currentNumber, versesToGo when currentNumber > 0 && versesToGo > 0 ->
            buildVerses updatedVerse (currentNumber - 1) (versesToGo - 1)
        | 0, 1 -> buildVerses updatedVerse 0 0
        | _ -> verses.Tail

    buildVerses List.empty startBottles takeDown
