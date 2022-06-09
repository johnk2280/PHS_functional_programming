// 43.3
// let try_find key m = 
//     try
//         Map.find key m
//     with
//         | :? System.Collections.Generic.KeyNotFoundException as ex -> None

let try_find key m = 
    let rec find = function
        | [] -> None
        | (k, value) :: tail -> if k = key then Some value else find tail

    find (Map.toList m)
