module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add student grade (school: School) : School =
    match school.TryFind grade with
    | None -> school.Add(grade, [ student ])
    | Some currentGradeStudents -> school.Add(grade, currentGradeStudents @ [ student ])
    
let sortSchoolValues (list: string list option) =
    list.Value
    |> List.sort
    
let roster (school: School) =
    school
    |> Map.keys
    |> Seq.map (school.TryFind >> sortSchoolValues)
    |> List.concat

let grade number (school: School) =
    match school.TryFind number with
    | Some strList -> List.sort strList
    | None -> List.empty
