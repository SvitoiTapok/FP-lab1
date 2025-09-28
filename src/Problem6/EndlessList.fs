module Problem6.EndlessList

let eulerFunc n =
    let numbers = Seq.initInfinite (fun i -> i)
    let squares = Seq.initInfinite (fun i -> i*i)
    let numSum = numbers |> Seq.take (n+1) |> List.ofSeq |> List.fold (fun acc x -> acc + x) 0
    let squareSum = squares |> Seq.take (n+1) |> List.ofSeq |> List.fold (fun acc x -> acc + x) 0
    numSum*numSum-squareSum


