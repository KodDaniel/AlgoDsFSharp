// Learn more about F# at http://fsharp.org

open System


    // Factorial: Common
    let rec factorial n =
        match n with
            0 -> 1
            | n-> n * factorial (n - 1);;

    // Factorial TAIL RECURSIVE
    let rec factorialTailRecursive (n,acc) =
        match n with
        0 -> acc
        |   n -> factorialTailRecursive ((n - 1),(n*acc));;

    // Length
    let rec length l =
        match l with
        [] -> 0
        | (h::t) -> 1 + length t;;
