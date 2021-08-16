module Hamming

    
    
let strandsAreEqual (strand1: string) (strand2: string) =
    strand1 = strand2
    
let splitStrand (strand: string) =
    strand.Split
   
let compareStrands (strand1: string) (strand2: string) =
    strand1
    |> splitStrand
    |> Seq.map
    
    

let strandsAreEqualLength (strand1: string) (strand2: string) =
    match strand1.Length = strand2.Length with
    | true -> compareStrands strand1 strand2
    | false -> None

    
let distance (strand1: string) (strand2: string) =
    match strandsAreEqual strand1 strand2 with
    | true -> Some 0
    | false -> strandsAreEqualLength strand1 strand2
    
