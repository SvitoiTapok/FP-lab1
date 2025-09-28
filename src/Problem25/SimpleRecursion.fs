module Problem25.SimpleRecursion

let eulerFunc n = 
    let rec fibRec (x1:bigint) (x2:bigint) targetCount = 
        if x2.ToString().Length >= targetCount then 2
        else 1+fibRec x2 (x1+x2) targetCount
    fibRec 1I 1I  n
