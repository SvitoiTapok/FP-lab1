module Problem25.EndlessList

let eulerFunc n = 
    let fibonachiNumbers = Seq.unfold(fun (a:bigint,b:bigint, c) -> Some((b, c),(b,a+b, c+1))) (1I,1I, 2)
    let number = fibonachiNumbers |> Seq.takeWhile (fun (x, c) -> x.ToString().Length < n) |> List.ofSeq |> List.last |> fun (x,c) -> c+1
    number

