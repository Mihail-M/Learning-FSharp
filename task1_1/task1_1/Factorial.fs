
let rec fact n = 
    if n = 0 then 1
    else n * fact (n - 1)

[<EntryPoint>]
let main argv = 

    System.Console.WriteLine "Hey, enter any positive number, please!"
    let n = System.Console.ReadLine()
    printfn "%d" (fact (int n))
    0 
