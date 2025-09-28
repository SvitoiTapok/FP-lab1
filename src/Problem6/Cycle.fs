module Problem6.Cycle

let eulerFunc n=
    let mutable sum = 0
    let mutable squareSum = 0
    for i in [1..n] do
        sum <- sum + i 
        squareSum <- squareSum + i*i
    sum*sum-squareSum
