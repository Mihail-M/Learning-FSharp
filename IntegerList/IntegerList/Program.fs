type IntList = Nil | Cons of int*IntList

let rec sumList list =
    match list with
        | Nil -> 0
        | Cons(h, t) -> h + sumList t

printf "%d" (sumList (Cons(2, Cons(3, Cons(-5,Nil)))))
//may be I define it better
//Later