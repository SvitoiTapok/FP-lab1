module Problem25.Match

let rec eulerFunc n = 
    let rec fib (a:bigint) (b:bigint) fibNumber n =
        match b with
        | _ when b.ToString().Length = n -> fibNumber
        | _ -> fib b (a+b) (fibNumber+1) n
    fib 1L 1L 2 n
