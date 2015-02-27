type Tree<'a> = Empty| Node of Tree<'a> * 'a * Tree<'a>

//heigth
let rec heigth T = 
    match T with 
        | Empty -> 0
        | Node (t1, _, t2) -> 1 + max (heigth t1) (heigth t2)
                

//Now I'm going to sort the list by a tree

let rec build list = 
    let rec insert elem T = 
        match T with 
            | Empty -> Node (Empty, elem, Empty)
            | Node (t1, n, t2) -> if elem < n then Node ((insert elem t1), n, t2)
                                  else Node (t1, n, (insert elem t2))
    
    match list with
        |[] -> Empty
        |elem::t -> insert elem (build t)

let rec foldTree seed T =
    match T with
        | Empty -> seed
        | Node(t1, elem, t2) -> foldTree (elem::(foldTree seed t2)) t1

let flatten T = foldTree [] T
let sort list = flatten (build list)


let myTree = build [1;8;4;2;0;6;9;2]


printfn "Heigth is %A" (heigth (myTree))
printfn "Heigth is %A" (heigth (build [1..10]))
