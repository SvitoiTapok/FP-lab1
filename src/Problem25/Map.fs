module Problem25.MapSolution

let eulerFunc n =
    let fibonachiNumbers = Seq.unfold(fun (a:bigint,b:bigint) -> Some(b,(b,a+b))) (1I,1I)
    let number = (fibonachiNumbers |> Seq.map(fun x -> x.ToString().Length) |> Seq.takeWhile (fun x -> x < 1000) |> List.ofSeq |> List.length)+2
    number