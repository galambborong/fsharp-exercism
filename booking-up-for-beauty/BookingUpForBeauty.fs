module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule appointmentDateDescription =
    appointmentDateDescription |> DateTime.Parse

let hasPassed appointmentDate = appointmentDate < DateTime.Now

let isAfternoonAppointment (appointmentDate: DateTime) : bool =
    failwith "Please implement the 'isAfternoonAppointment' function"

let description (appointmentDate: DateTime) : string =
    failwith "Please implement the 'description' function"

let anniversaryDate () : DateTime =
    failwith "Please implement the 'anniversaryDate' function"
