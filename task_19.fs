// 48.4.1
let rec fibo1 n n1 n2 =
    if n < 1 then n2
    else fibo1 (n - 1) (n1 + n2) n1 

// fibo1 6 1 0
// fibo1 6 5 3

// 48.4.2

let rec fibo2 n c =
    if n = 0 then c 0
    elif n = 1 then c 1
    else fibo2 (n - 1) (fun x -> c x) + fibo2 (n - 2) (fun x -> c x)

// fibo2 6 id


// 48.4.3 
let rec bigList n k =
    let rec big_list n tail = 
        if n = 0 then tail
        else big_list (n - 1) (1 :: tail)

    big_list n []

// bigList 230000 id
