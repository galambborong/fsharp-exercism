module BinarySearch

let x = [|1;2;3|]

let find (input: int[]) (value: int) =
    let inputLength = input.Length
    let midWayIndex = inputLength / 2
    
    let x = input.[midWayIndex]
    
    let rec doTheFind currentX currentMidWay value =
        match currentX, value with
        | x, y when x = y -> Some currentMidWay
        | x, y when x > y ->
            let newMidWayIndex = midWayIndex / 2
            let newX = input.[newMidWayIndex]
            doTheFind newX newMidWayIndex value
        | x, y when x < y ->
            let newMidWayIndex = (currentMidWay + (currentMidWay / 2))
            let newX = input.[newMidWayIndex]
            doTheFind newX newMidWayIndex value
        | _ -> None
        
    doTheFind x midWayIndex value
        
        
// find [|1; 2; 3|] 2
    
        
    
    