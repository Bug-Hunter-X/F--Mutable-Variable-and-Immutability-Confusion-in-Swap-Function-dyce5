let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //Prints 20 20 as expected

//However, if you try to swap immutable values:

let x = 10
let y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y //This will cause a compile-time error because x and y are immutable