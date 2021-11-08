module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add student grade (school: School) : School =
    // TODO Check this works without pattern match
    match school.TryFind grade with
    | None -> school.Add(grade, [ student ])
    | Some currentGradeStudents -> school.Add(grade, currentGradeStudents @ [ student ])

let roster (school: School) : string list = school |> Map.values

let grade (number: int) (school: School) : string list =
    failwith "You need to implement this function."
