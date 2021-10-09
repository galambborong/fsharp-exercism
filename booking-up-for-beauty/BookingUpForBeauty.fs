module BookingUpForBeauty

// The following line is needed to use the DateTime type
open System

let schedule appointmentDateDescription =
    appointmentDateDescription |> DateTime.Parse

let hasPassed appointmentDate = appointmentDate < DateTime.Now

let isAfternoonAppointment (appointmentDate: DateTime) =
    appointmentDate.Hour >= 12
    && appointmentDate.Hour < 18

let description (appointmentDate: DateTime) : string =
    $"You have an appointment on {appointmentDate}."

let anniversaryDate () = DateTime(DateTime.Now.Year, 9, 15)
