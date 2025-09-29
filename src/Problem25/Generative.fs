module Problem25.Generative

let eulerFunc n =
    let fibonachiNumbers = Seq.unfold(fun (a:bigint,b:bigint) -> Some(b,(b,a+b))) (1I,1I)
    let number = (fibonachiNumbers |> Seq.takeWhile (fun x -> x.ToString().Length < n) |> List.ofSeq |> List.fold(fun acc x -> acc+1) 0) + 2
    number
