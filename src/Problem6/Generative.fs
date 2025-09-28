module Problem6.Generative

let sum acc x=
    acc + x

let eulerFunc n=
    //генерация последовательностей
    let numbers = [1..n] 
    let squares = [for i in 1..n -> i*i]
    //свертка
    let numbersSum = numbers |> List.fold(sum) 0
    let squareSum= squares |> List.fold(sum) 0
    numbersSum*numbersSum - squareSum

    


