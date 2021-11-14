module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add student grade school =
    match school |> Map.tryFind grade with
    | Some currentStudents -> school.Add(grade, currentStudents @ [ student ])
    | None -> school.Add(grade, [ student ])

let roster school =
    school
    |> Map.toList
    |> List.collect (snd >> List.sort)

let grade number school =
    match school |> Map.tryFind number with
    | Some studentsInGrade -> studentsInGrade |> List.sort
    | None -> List.empty
