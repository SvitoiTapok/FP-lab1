module Problem6.Tests

open Xunit

open Problem6.SimpleRecursion
open Problem6.TailRecursion  
open Problem6.Cycle
open Problem6.MapSolution
open Problem6.Generative
open Problem6.EndlessList

module Problem6TestData =
    let testCases = [
        (3, 22)    // n=3, expected=22
        (10, 2640) // n=10, expected=2640
        (100, 25164150) // n=100, expected=25164150
    ]

module SimpleRecursionTests =
    
    [<Theory>]
    [<InlineData(1, 0)>]    
    [<InlineData(2, 4)>]    
    [<InlineData(3, 22)>]    
    [<InlineData(10, 2640)>] 
    [<InlineData(100, 25164150)>] 
    let ``SimpleRecursion - should calculate correct sum square difference`` (n, expected) =
        let actual = SimpleRecursion.eulerFunc n
        printfn "Algorithm: SimpleRecursion | Input: n=%d | Expected: %d | Actual: %d" n expected actual
        Assert.Equal(expected, actual)

module TailRecursionTests =
    
    [<Theory>]
    [<InlineData(1, 0)>]
    [<InlineData(2, 4)>]
    [<InlineData(3, 22)>]
    [<InlineData(10, 2640)>]
    [<InlineData(100, 25164150)>]
    let ``TailRecursion - should calculate correct sum square difference`` (n, expected) =
        let actual = TailRecursion.eulerFunc n
        printfn "Algorithm: TailRecursion | Input: n=%d | Expected: %d | Actual: %d" n expected actual
        Assert.Equal(expected, actual)

    [<Fact>]
    let ``TailRecursion - should work with very large numbers without stack overflow`` () =
        let n = 10000
        let actual = TailRecursion.eulerFunc n
        printfn "Algorithm: TailRecursion | Input: n=%d | Expected: positive number | Actual: %d" n actual
        Assert.True(actual > 0)

module CycleTests =
    
    [<Theory>]
    [<InlineData(1, 0)>]
    [<InlineData(2, 4)>]
    [<InlineData(3, 22)>]
    [<InlineData(10, 2640)>]
    [<InlineData(100, 25164150)>]
    let ``Cycle - should calculate correct sum square difference`` (n, expected) =
        let actual = Cycle.eulerFunc n
        printfn "Algorithm: Cycle | Input: n=%d | Expected: %d | Actual: %d" n expected actual
        Assert.Equal(expected, actual)

module MapSolutionTests =
    
    [<Theory>]
    [<InlineData(1, 0)>]
    [<InlineData(2, 4)>]
    [<InlineData(3, 22)>]
    [<InlineData(10, 2640)>]
    [<InlineData(100, 25164150)>]
    let ``MapSolution - should calculate correct sum square difference`` (n, expected) =
        let actual = MapSolution.eulerFunc n
        printfn "Algorithm: MapSolution | Input: n=%d | Expected: %d | Actual: %d" n expected actual
        Assert.Equal(expected, actual)

module GenerativeTests =
    
    [<Theory>]
    [<InlineData(1, 0)>]
    [<InlineData(2, 4)>]
    [<InlineData(3, 22)>]
    [<InlineData(10, 2640)>]
    [<InlineData(100, 25164150)>]
    let ``Generative - should calculate correct sum square difference`` (n, expected) =
        let actual = Generative.eulerFunc n
        printfn "Algorithm: Generative | Input: n=%d | Expected: %d | Actual: %d" n expected actual
        Assert.Equal(expected, actual)

module EndlessListTests =
    
    [<Theory>]
    [<InlineData(1, 0)>]
    [<InlineData(2, 4)>]
    [<InlineData(3, 22)>]
    [<InlineData(10, 2640)>]
    [<InlineData(100, 25164150)>]
    let ``EndlessList - should calculate correct sum square difference`` (n, expected) =
        let actual = EndlessList.eulerFunc n
        printfn "Algorithm: EndlessList | Input: n=%d | Expected: %d | Actual: %d" n expected actual
        Assert.Equal(expected, actual)