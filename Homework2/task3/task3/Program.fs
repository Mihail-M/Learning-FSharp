let rec multNumber n =
    if n < 10 then n
    else (n % 10) * multNumber (n/10)

let n = System.Console.ReadLine()
printf "%d" (multNumber (int n))