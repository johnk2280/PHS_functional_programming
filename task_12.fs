// 34.1
let rec upto = function
 | n when n <= 0 -> []
 | n -> upto(n - 1) @ [n]


// 34.2
let rec dnto = function
 | n when n <= 0 -> []
 | n -> n :: dnto(n - 1)


// 34.3
let rec evenn = function
 | n when n < 0 -> []
 | n when n % 2 = 0 -> evenn(n - 2) @ [n]
 | n when n % 2 = 1 -> evenn(n - 3) @ [n - 1]

