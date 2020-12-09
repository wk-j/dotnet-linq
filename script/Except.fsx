open System.Linq

[<CLIMutable>]
type Student = {
    FirstName: string
    LastName: string
}

let a = { FirstName = "F"; LastName = "L" }
let b = { FirstName = "F"; LastName = "I" }
let c = { FirstName = "F"; LastName = "L" }

let listA = [a;b]
let listB = [c]

let axb = listA.Except(listB)
printfn "%A" axb
