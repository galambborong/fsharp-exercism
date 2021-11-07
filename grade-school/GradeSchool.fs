module GradeSchool

type School = Map<int, string list>

let empty: School = s(0, [""])

let add (student: string) (grade: int) (school: School) =
    printfn $"Grade: {school}"
    let list = match school.ContainsKey(grade) with
                | true -> school.[grade] @ [student]
                | false -> List.empty
    list
    
    match school.ContainsKey(grade) with
    | false -> school.Add(grade, [student])
    | true -> school.Add(grade, list)
    
    // add "w" 1 school

let roster (school: School): string list = failwith "You need to implement this function."

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
