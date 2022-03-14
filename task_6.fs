// 17.1
let rec pow = function
 | (s, 0) -> ""
 | (s, n) when n < 0 -> ""
 | (s, n) -> s + pow(s, n - 1)


// 17.2
let isIthChar(s: string, n, c) = s.[n] = c


// 17.3
let rec occFromIth = function
 | (s, n, c) when n > (String.length s) - 1 -> 0
 | (s, n, c) when not (isIthChar(s, n, c)) -> 0 + occFromIth(s, n + 1, c)
 | (s, n, c) when isIthChar(s, n, c) -> 1 + occFromIth(s, n + 1, c)
