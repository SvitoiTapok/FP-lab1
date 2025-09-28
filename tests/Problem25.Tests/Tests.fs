module Problem6.Tests

open Xunit
open FsUnit.Xunit

open Problem25.SimpleRecursion
open Problem25.TailRecursion  
open Problem25.Cycle
open Problem25.MapSolution
open Problem25.Generative
open Problem25.EndlessList

module Problem6TestData =
    let testCases = [
        (3, 22)    // n=3, expected=22
        (10, 2640) // n=10, expected=2640
        (100, 25164150) // n=100, expected=25164150
    ]

module SimpleRecursionTests =
    
    [<Theory>]
    [<MemberData(nameof(Problem6TestData.testCases))>]
    let ``SimpleRecursion - should calculate correct sum square difference`` (n, expected) =
        let actual = SimpleRecursion.eulerFunc n
        actual |> should equal expected

module TailRecursionTests =
    
    [<Theory>]
    [<MemberData(nameof(Problem6TestData.testCases))>]
    let ``TailRecursion - should calculate correct sum square difference`` (n, expected) =
        let actual = TailRecursion.eulerFunc n
        actual |> should equal expected

    [<Fact>]
    let ``TailRecursion - should work with very large numbers without stack overflow`` () =
        let actual = TailRecursion.eulerFunc 10000
        actual |> should be (greaterThan 0)

module CycleTests =
    
    [<Theory>]
    [<MemberData(nameof(Problem6TestData.testCases))>]
    let ``Cycle - should calculate correct sum square difference`` (n, expected) =
        let actual = Cycle.eulerFunc n
        actual |> should equal expected

module MapSolutionTests =
    
    [<Theory>]
    [<MemberData(nameof(Problem6TestData.testCases))>]
    let ``MapSolution - should calculate correct sum square difference`` (n, expected) =
        let actual = MapSolution.eulerFunc n
        actual |> should equal expected

module GenerativeTests =
    
    [<Theory>]
    [<MemberData(nameof(Problem6TestData.testCases))>]
    let ``Generative - should calculate correct sum square difference`` (n, expected) =
        let actual = Generative.eulerFunc n
        actual |> should equal expected

module EndlessListTests =
    
    [<Theory>]
    [<MemberData(nameof(Problem6TestData.testCases))>]
    let ``EndlessList - should calculate correct sum square difference`` (n, expected) =
        let actual = EndlessList.eulerFunc n
        actual |> should equal expected

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