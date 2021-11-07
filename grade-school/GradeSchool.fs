module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add (student: string) (grade: int) (school: School) =
    let gradeExists = school |> Map.tryFind grade
    
    match gradeExists with
    | None -> school.Add(grade, [student])
    | Some _ -> school
    
    
    
// add "p" 1 a

let roster (school: School): string list = failwith "You need to implement this function."

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
