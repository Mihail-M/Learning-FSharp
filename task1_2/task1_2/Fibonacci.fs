
let rec fib n = 
    if n <= 1 then n
    else fib (n - 1) + fib (n - 2)


[<EntryPoint>]
let main argv = 
    System.Console.WriteLine "Enter any positive number!"
    let n = System.Console.ReadLine();
    for i in 1..(int n) do
        printf "%d " (fib i)
    0 
