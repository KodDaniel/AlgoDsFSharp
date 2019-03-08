// Learn more about F# at http://fsharp.org

open System

     // Rotate
    type direction = North | South | East | West;;

    let rotate dir =
        match dir with
            North -> East
            | East -> South
            | South -> West
            | West -> North;;

        type year = Fresher | Second | Third
        type rank = Assistant | Docent | Professor
        type person = Student of (string * year)| Faculty of (string * rank)|Staff of (string * int);;

        let studentPerson = Student ("Sally",Second);;
        let facultyPerson = Faculty ("John", Docent);;
        let staffPerson = Staff ("Suzie", 10);;


        //name
        let name person =
            match person with
        (Student(n,_)) -> n
        | (Staff(n,_)) -> n
        | (Faculty(n,_)) -> n;;

        let result = name(studentPerson);;

        printfn "name: %A" result;;
     

        //Norespect
        let norespect person =
            match person with
            (Faculty(_,Assistant)) -> true
            | (Student(_,Fresher)) -> true
            | (Student(_,Second)) -> true
            | (Staff(_,r)) -> (r<5)
            | _ -> false;;

            let result2 = norespect(studentPerson);;
            printfn "norespect: %A" result2;;

              

               // Concat
               let rec concat (l1,l2) =
                    match l1 with
                    [] -> l2
                    | (h::t) -> h::(concat (t,l2));;


                        let result3 = concat([1;2;3],[4;5;6]);;
                        printfn "concat: %A" result3;;

                // ConcatReverse
                let rec reverse l =
                    match l with
                    [] -> []
                    | (h::t) -> concat (reverse t, [h]);;

                      let result4 = reverse([1;2;3;4;5;6]);;
                        printfn "reverse: %A" result4;;
                   

                                                   

                    //  Efficient List Reversal
                         let rec rev (l,r) =
                            match l with
                            [] -> r
                            | (h::t) -> rev (t, h::r);;

                         let reverseAccu l = rev (l,[]);;

                         
                        let result5 = reverseAccu([1;2;3;4;5;6]);;
                        printfn "Efficient List Reversal: %A" result5;;

                        Console.ReadLine();