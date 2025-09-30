module Problem6.Generative

let eulerFunc n=
    //генерация последовательностей
    let numbers = [1..n] 
    let squares = [for i in 1..n -> i*i]
    //свертка
    let numbersSum = numbers |> List.fold(+) 0
    let squareSum= squares |> List.fold(+) 0
    numbersSum*numbersSum - squareSum

    


