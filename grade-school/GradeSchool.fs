module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let school = Map.empty

let add (student: string) (grade: int) (school: School): School =
    let list = match school.ContainsKey(grade) with
                | true -> school.[grade] @ [student]
                | false -> List.empty)
    
    match school.ContainsKey(grade) with
    | false -> school.Add(grade, [student])
    | true -> school.Add(grade, list)
    
    // add "pK" 2 school

let roster (school: School): string list = failwith "You need to implement this function."

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
