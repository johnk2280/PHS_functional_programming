type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

// var 1
let time_converting = function
 | (x, PM) -> (x.hours + 12) * 60 + x.minutes
 | (x, AM) -> x.hours * 60 + x.minutes


let (.>.) x y = (time_converting (x, x.f)) > (time_converting (y, y.f))

// var 2
let convert = function
 | AM -> 0
 | PM -> 12

let time_converting_2 (x: TimeOfDay)= (x.hours + (convert x.f)) * 60 + x.minutes

let (.>.) x y = (time_converting_2 x) > (time_converting_2 y)

// let a = { hours = 6; minutes = 34; f = PM}
// let b = { hours = 7; minutes = 34; f = AM}

// a .>. b