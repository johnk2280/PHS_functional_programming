// 39.1
let rec get_odd = function
    | ([], pos) -> []
    | (head::tail, pos) when pos % 2 = 1-> head :: get_odd (tail, pos + 1)
    | (head::tail, pos) when pos % 2 = 0 -> get_odd (tail, pos + 1)

let rmodd list = get_odd (list, 0)

// 39.2
let rec del_even = function
    | [] -> []
    | head :: tail when head % 2 = 1 -> head :: del_even tail
    | head :: tail when head % 2 = 0 -> del_even tail

// 39.3
let rec multiplicity x xs = match xs with
    | [] -> 0
    | head::tail -> (if head = x then 1 else 0) + multiplicity x tail

// 39.4
let rec get_even = function
    | ([], pos) -> []
    | (head::tail, pos) when pos % 2 = 0-> head :: get_even (tail, pos + 1)
    | (head::tail, pos) when pos % 2 = 1 -> get_even (tail, pos + 1)

let split list = match list with
    | [] -> ([], [])
    | _ -> (get_even (list, 0), get_odd (list, 0))

// 39.5
let rec zip (xs1, xs2) = match (xs1, xs2) with
 | ([], []) -> []
 | (head_1 :: tail_1, head_2 :: tail_2) -> (head_1, head_2) :: zip (tail_1, tail_2)

// let a = [1; 2; 3]
// let b = [5; 6; 7]

// zip (a, b)