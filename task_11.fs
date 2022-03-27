type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

let time_converting = function
 | (x, PM) -> (x.hours + 12) * 60 + x.minutes
 | (x, AM) -> x.hours * 60 + x.minutes


let (.>.) x y = (time_converting (x, x.f)) > (time_converting (y, y.f))
