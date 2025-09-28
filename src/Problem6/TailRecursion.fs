module Problem6.TailRecursion

let rec calculateSquareSummRec n sum =
    if n = 0 then sum
    else calculateSquareSummRec (n-1) (sum+n*n)
//функция для "оборачивания" рекурсии и удобного использования в программе без прописывания 0
let calculateSquareSumm n =
    calculateSquareSummRec n 0


let rec calculateSumRec sum n=
    if n = 0 then sum
    else calculateSumRec (sum+n) (n-1)
//функция для "оборачивания" рекурсии и удобного использования в программе без прописывания 0. Из-за изменения порядка аргументов возможно записать ее короче
let calculateSum =
    calculateSumRec 0

let eulerFunc n =
    let sum =  calculateSum n
    sum * sum - calculateSquareSumm n 
    


