module Problem25.Cycle

let eulerFunc n=
    let mutable x1:bigint = 1I
    let mutable x2:bigint = 1I
    let mutable c = 2
    
    while x2.ToString().Length < n do
        let buf  = x2
        x2 <- x1+x2
        x1 <- buf
        c <- c+1
    c

