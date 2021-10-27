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

let recite (startBottles: int) (takeDown: int) =
    let rec buildVerses verses currentNumber versesToGo =
        let append = 
            match currentNumber with
            | x when x > 2 -> standardVerse x
            | 2 -> twoBottleVerse
            | 1 -> oneBottleVerse
            | 0 -> noBottleVerse
            | _ -> failwith "This case should never occur"
            |> List.append verses
        
        if versesToGo >= 0 && currentNumber >= 0 then 
            buildVerses append (currentNumber - 1) (versesToGo - 1)
        else verses
        
    buildVerses List.empty startBottles takeDown
    
    // recite 5 2
    // recite 99 10
    // recite 2 2
    // recite 2 3
