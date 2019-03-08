// Learn more about F# at http://fsharp.org

open System

// Swap 
let swap((a:int array),(i:int),(j:int)) =
let temp = a.[i]
in a.[i] =a.[j];
a.[j]=temp;;


    // maxToBack
    let rec maxToBack ((a:int array),(i:int),(j:int)) =
    if i=j
    then ()
    else (
    if a.[i]>a.[i+1]
    then (swap (a,i,i+1); maxToBack (a,i+1,j))
    else maxToBack (a,i+1,j));;

    // bubbleSort
    let rec bubble (a,i,j) =
        if i=j
        then ()
        else (maxToBack (a,i,j); bubble (a,i,j-1));;


