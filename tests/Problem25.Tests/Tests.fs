module Problem25.Tests



module CycleTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]   
    let ``Cycle - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Problem25.Cycle.findFibonacciIndexWithDigits digits
        Assert.Equal(expectedIndex, actual)

module TailRecursionTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``TailRecursion - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Problem25.TailRecursion.findFibonacciIndexWithDigits digits
        Assert.Equal(expectedIndex, actual)

module MapSolutionTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``MapSolution - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Problem25.Map.findFibonacciIndexWithDigits digits
        Assert.Equal(expectedIndex, actual)

module GenerativeTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``Generative - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Problem25.Generative.findFibonacciIndexWithDigits digits
        Assert.Equal(expectedIndex, actual)

module EndlessListTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``EndlessList - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Problem25.EndlessList.findFibonacciIndexWithDigits digits
        Assert.Equal(expectedIndex, actual)

module SimpleRecursionTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``SimpleRecursion - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Problem25.SimpleRecursion.findFibonacciIndexWithDigits digits
        Assert.Equal(expectedIndex, actual)