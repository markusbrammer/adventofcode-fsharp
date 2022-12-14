namespace AdventOfCode

open System.IO
open Common

module Runner =

    let run runExample year day part (solver: Day<_, _, _>) =
        let run' part solve =
            let fileName =
                Path.Combine((if runExample then "examples" else "inputs"), $"day%02i{day}.txt")

            let result = fileName |> solver.parse |> solve

            printfn $"Year %i{year} Day %02i{day}-%i{part}: {result}"

        match part with
        | 1 -> run' 1 solver.part1
        | 2 -> run' 2 solver.part2
        | _ -> ()
