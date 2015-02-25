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

//for N^2
let rec flatten2 T = 
    match T with 
        |Empty -> []
        |Node(t1, n, t2) -> (flatten2 t1) @ n::(flatten2 t2)

//linear time
let rec foldTree seed T =
    match T with
        | Empty -> seed
        | Node(t1, elem, t2) -> foldTree (elem::(foldTree seed t2)) t1

let flatten T = foldTree [] T
let sort list = flatten (build list)

//for output
let rec printTree T = 
    match T with
    |Empty -> printf ""
    |Node(t1, n, t2) -> printTree t1 
                        printf "%A " n 
                        printTree t2


let myList = [1;8;4;2;0;6;9;2]
let myTree = build myList

printfn "%A" (sort myList)
printfn "Heigth is %A" (heigth (myTree))
printTree myTree