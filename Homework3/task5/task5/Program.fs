type Tree<'a, 'b> = Tree of  Tree<'a, 'b> *'a * Tree<'a, 'b> | Leaf of 'b


let rec calculate T =
    match T with
    | Tree(left, op, right) ->
        
        match op with
        | '+' -> calculate left + calculate right
        | '-' -> calculate left - calculate right
        | '*' -> calculate left * calculate right
        | '/' -> let checkZero = calculate right
                 if (checkZero = 0 ) then 
                    failwith("divide  by zero")
                 else 
                    calculate left / checkZero
        | _ -> failwith("Invalid operation")
    | Leaf x -> x

let testTree0 = Tree(Tree(Leaf 2, '+', Leaf 3), '*' , Tree(Leaf 3, '+',Leaf 2)) 
let testTree1 = Tree(Tree(Leaf 2, '+', Leaf 3), '/' , Tree(Leaf 2, '-',Leaf 2)) 
let testTree2 = Tree(Tree(Leaf 2, '+', Leaf 3), '*' , Tree(Leaf 3, '-',Tree(Leaf 2, '+', Leaf 100)))
let testTree3 = Tree(Tree(Leaf 2, '.', Leaf 3), '*' , Tree(Leaf 3, '-',Tree(Leaf 2, '+', Leaf 100)))

try printf "%d\n" (calculate testTree0)  with Failure(msg) -> printfn "%s" msg
try printf "%d\n" (calculate testTree1)  with Failure(msg) -> printfn "%s" msg
try printf "%d\n" (calculate testTree2)  with Failure(msg) -> printfn "%s" msg
try printf "%d\n" (calculate testTree3)  with Failure(msg) -> printfn "%s" msg



