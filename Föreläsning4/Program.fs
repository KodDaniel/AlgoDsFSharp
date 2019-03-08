// Learn more about F# at http://fsharp.org

open System


    //SortingBool 
    let rec sorted l =
        match l with
        [] -> true
        | [v] -> true
        | (v1::(v2::r)) -> (v1 <= v2) && sorted (v2::r);;

        let result = sorted([1;2;4;2]);;
         printfn "reverse: %A" result;;


   


     // InsertInOrder
     let rec insertInOrder (u,l) =
        match l with
        [] -> [u]
        | (v::r) ->
        if (u<=v)
        then u::v::r
        else v::(insertInOrder (u,r));;


         let result2 = insertInOrder(3,[1;2;4;2]);;
          printfn "insertInOrder: %A" result2;;

          //Sort AND insertInOrder
          let rec insertInOrder2 (u,l) =
                match l with
                [] -> [u]
                | (v::r) ->
                if (u<=v)
                then u::l
                else v::(insertInOrder2 (u,r));;

                let rec sort l =
                match l with
                [] -> []
                | (v::r) -> insertInOrder2 (v,(sort r));;

        let result3 = sort([3;19;12;1]);;
         printfn "insertInOrderAndSort: %A" result3;;

         Console.ReadLine();