module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add student grade (school: School) : School =
    // TODO Check this works without pattern match
    match school.TryFind grade with
    | None -> school.Add(grade, [ student ])
    | Some currentGradeStudents -> school.Add(grade, currentGradeStudents @ [ student ])

let roster (school: School) = 
    school
    |> Map.keys
    |> Seq.map school.TryFind
    |> Seq.map (fun (elem: string list option) -> elem.Value |> List.sort)
    |> List.concat
    
let grade (number: int) (school: School) : string list =
    match school.TryFind number with
    | Some (strList: string list) -> List.sort strList
    | None -> List.empty
