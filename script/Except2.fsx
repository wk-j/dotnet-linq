open System.Linq
open System
open System.Collections.Generic

type Student(f: string, l: string) =
    new () = Student("", "")
    member x.FirstName = f
    member x.LastName = l


let a = Student("F", "L")
let b = Student("F", "X")
let c = Student("F", "L")

let listA = [a;b]
let listB = [c]

let comparer =
        { new IEqualityComparer<Student> with
            member _.Equals(x: Student, y: Student): bool =
                (x.FirstName, x.LastName) = (x.FirstName, x.LastName)
            member _.GetHashCode(x: Student): int =
                (x.FirstName, x.LastName).GetHashCode() }

let axb =
    listA.Except(listB, comparer)

for item in axb do
    printfn "%A %A" (item.FirstName) (item.LastName)