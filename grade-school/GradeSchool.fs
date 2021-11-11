module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add student grade (school: School) =
    match school.TryFind grade with
    | Some currentStudents -> school.Add(grade, currentStudents @ [ student ])
    | None -> school.Add(grade, [ student ])

let sortStudentsInGrade (list: string list option) = list.Value |> List.sort

let roster school =
    school
    |> Map.keys
    |> Seq.map (school.TryFind >> sortStudentsInGrade)
    |> List.concat

let grade number (school: School) =
    match school.TryFind number with
    | Some studentsInGrade -> List.sort studentsInGrade
    | None -> List.empty
