module Problem6.MapSolution

let sum acc x = 
    acc + x

let eulerFunc n =
    let numbers = [1..n] 
    let squares = numbers |> List.map(fun x -> x*x)
    let numbersSum = numbers |> List.fold(sum) 0
    let squareSum = squares |> List.fold(sum) 0
    numbersSum*numbersSum - squareSum
