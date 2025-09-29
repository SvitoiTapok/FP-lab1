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
        Assert.Equal(expected, actual)

    [<Fact>]
    let ``TailRecursion - should work with very large numbers without stack overflow`` () =
        let actual = TailRecursion.eulerFunc 10000
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
        Assert.Equal(expected, actual)

// module IntegrationTests =
    
//     [<Theory>]
//     [<InlineData(10)>]
//     [<InlineData(20)>]
//     [<InlineData(50)>]
//     [<InlineData(100)>]
//     let ``All implementations should return same result for n=%d`` (n) =
//         let results = [
//             SimpleRecursion.eulerFunc n
//             TailRecursion.eulerFunc n  
//             Cycle.eulerFunc n
//             MapSolution.eulerFunc n
//             Generative.eulerFunc n
//             EndlessList.eulerFunc n
//         ]
        
//         // Все результаты должны быть одинаковыми
//         let firstResult = List.head results
//         results |> List.iter (should equal firstResult)
        
//     [<Fact>]
//     let ``All implementations should agree on known Euler answer for n=100`` () =
//         let eulerAnswer = 25164150
        
//         let results = [
//             SimpleRecursion.eulerFunc 100
//             TailRecursion.eulerFunc 100
//             Cycle.eulerFunc 100
//             MapSolution.eulerFunc 100  
//             Generative.eulerFunc 100
//             EndlessList.eulerFunc 100
//         ]
        
//         results |> List.iter (should equal eulerAnswer)