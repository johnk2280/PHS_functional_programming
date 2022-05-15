type TimeOfDay = { hours: int; minutes: int; f: string }

let time_converting (x: TimeOfDay) =
    if x.f = "PM" then
        (x.hours + 12) * 60 + x.minutes
    else
        x.hours * 60 + x.minutes

let (.>.) x y = (time_converting x) > (time_converting y)
