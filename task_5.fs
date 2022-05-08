// 16.1
let notDivisible = fun (n, m) -> m % n = 0


let rec division = function
 | (n, 1) -> true
 | (n, m) -> n % m <> 0  && division(n, m - 1)

// 16.2
let rec prime = function 
 | 1 | 2 -> true
 | n ->  division(n, n - 1)
 
