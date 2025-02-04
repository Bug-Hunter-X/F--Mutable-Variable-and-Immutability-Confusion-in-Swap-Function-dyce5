let swap (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable x = ref 10
let mutable y = ref 20

swap x y
printfn "%d %d" !x !y //Prints 20 10

//Alternatively, using tuples for immutability:

let swap (x, y) = (y, x)

let x, y = swap (10, 20)
printfn "%d %d" x y //Prints 20 10