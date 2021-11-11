module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add student grade (school: School) =
    match school.TryFind grade with
    | Some currentStudents -> school.Add(grade, currentStudents @ [ student ])
    | None -> school.Add(grade, [ student ])

let roster (school: School) =
    school
    |> Map.toList
    |> List.collect (snd >> List.sort)

let grade number (school: School) =
    match school.TryFind number with
    | Some studentsInGrade -> List.sort studentsInGrade
    | None -> List.empty
