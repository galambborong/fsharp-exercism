module GradeSchool

type School = Map<int, string list>

let empty: School = Map []

let add (student: string) (grade: int) (school: School) =
    match school.TryFind grade with
    | None -> school.Add(grade, [student])
    | Some currentGradeStudents -> school.Add(grade, currentGradeStudents @ [student])
    
    
    
// add "p" 1

let roster (school: School): string list = failwith "You need to implement this function."

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
