namespace HackerRankFsharpSolutions

module StringManipulationProblemsFsharp =
    let alternatingCharacters (name : string) =
        let mutable count = 0
        let mutable previousCharToCheck = name.[0]

        for i in 1..name.Length-1 do
            let newChar = name.[i]
            if previousCharToCheck = newChar then
                count <- count+1
            else
                previousCharToCheck <- newChar
        count
