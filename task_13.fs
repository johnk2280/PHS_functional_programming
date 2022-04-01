// 39.1
let rmodd l =
    let rec get_odd = function
        | 

// 39.2
let rec del_even = ...

// 39.3
let rec multiplicity x xs = match xs with
 | [] -> 0
 | head::tail -> (if head = x then 1 else 0) + multiplicity x tail

// 39.4
let rec split = ...

// 39.5
let rec zip (xs1,xs2) = function
 | 

// multiplicity 4 [1; 2; 3; 4; 4; 4; 5]