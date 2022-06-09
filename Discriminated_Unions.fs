type Animal = 
 | Cat
 | Dog
 | Mouse

let barsik = Cat
let bobik = Dog

let animal_tag = function
 | Cat -> "кот"
 | Dog -> "собака"
 | Mouse -> "мышь"

let animal_big = function
 | Cat | Dog -> true
 | _ -> false

animal_tag Dog
animal_big Dog

type Animal = 
 | Cat of int
 | Dog of int
 | Mouse of float

 let barsik = Cat 5
 let mike = Mouse (3.14 - 2.78)

 let barsik1 = Cat (25 / 5)
 barsik = barsik1
 barsik > barsik1
 barsik1 > barsik
 barsik = mike
 mike > barsik

type Animal = 
 | Cat of int
 | Dog of int
 | Mouse of int * int

let animal_age = function
 | Cat a -> a * 7
 | Dog b -> b * 4
 | Mouse (c, d) -> c * d

animal_age (Cat 5)
animal_age (Dog 4)
animal_age (Mouse (2, 3))