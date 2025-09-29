module Problem25.Tests

open Xunit

open Problem25.SimpleRecursion
open Problem25.TailRecursion  
open Problem25.Cycle
open Problem25.MapSolution
open Problem25.Generative
open Problem25.EndlessList


module CycleTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]   
    let ``Cycle - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Cycle.eulerFunc digits
        printfn "Algorithm: Cycle | Input: %d digits | Expected index: %d | Actual index: %d" digits expectedIndex actual
        Assert.Equal(expectedIndex, actual)

module TailRecursionTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``TailRecursion - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = TailRecursion.eulerFunc digits
        printfn "Algorithm: TailRecursion | Input: %d digits | Expected index: %d | Actual index: %d" digits expectedIndex actual
        Assert.Equal(expectedIndex, actual)

module MapSolutionTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``MapSolution - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = MapSolution.eulerFunc digits
        printfn "Algorithm: MapSolution | Input: %d digits | Expected index: %d | Actual index: %d" digits expectedIndex actual
        Assert.Equal(expectedIndex, actual)

module GenerativeTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``Generative - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = Generative.eulerFunc digits
        printfn "Algorithm: Generative | Input: %d digits | Expected index: %d | Actual index: %d" digits expectedIndex actual
        Assert.Equal(expectedIndex, actual)

module EndlessListTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``EndlessList - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = EndlessList.eulerFunc digits
        printfn "Algorithm: EndlessList | Input: %d digits | Expected index: %d | Actual index: %d" digits expectedIndex actual
        Assert.Equal(expectedIndex, actual)

module SimpleRecursionTests =
    
    [<Theory>] 
    [<InlineData(3, 12)>]
    [<InlineData(4, 17)>]  
    [<InlineData(1000, 4782)>]
    let ``SimpleRecursion - should find first Fibonacci number with N digits`` (digits: int, expectedIndex: int) =
        let actual = SimpleRecursion.eulerFunc digits
        printfn "Algorithm: SimpleRecursion | Input: %d digits | Expected index: %d | Actual index: %d" digits expectedIndex actual
        Assert.Equal(expectedIndex, actual)