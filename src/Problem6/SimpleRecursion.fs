module Problem6.SimpleRecursion

let rec calculateSquareSumm n =
    if n = 0 then 0
    else n*n+calculateSquareSumm (n-1) 
let rec calculateSum n=
    if n = 0 then 0
    else n + calculateSum (n-1)

let eulerFunc n =
    let sum = calculateSum n
    sum*sum - calculateSquareSumm n 


