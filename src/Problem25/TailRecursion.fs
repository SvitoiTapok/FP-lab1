module Problem25.TailRecursion

let eulerFunc n =
    let rec fibRec (x1:bigint) (x2:bigint) number targetCount = 
        if x2.ToString().Length >= targetCount then number
        else fibRec x2 (x1+x2) (number+1) targetCount

    fibRec 1I 1I 2 n
