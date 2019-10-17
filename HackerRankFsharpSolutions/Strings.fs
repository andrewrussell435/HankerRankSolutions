namespace HackerRankFsharpSolutions

module StringManipulationProblemsFsharp =
    //Solution for Alternating Characters
    //https://www.hackerrank.com/challenges/alternating-characters/problem

    //Attempt 3
    let rec getAlternatingCharacterString (testString : string ) : string = 
        if testString.Length = 1 then
            testString
        elif testString.[0] = testString.[1] then
            getAlternatingCharacterString testString.[1..testString.Length-1]
        else
            testString.[0].ToString() + getAlternatingCharacterString testString.[1..testString.Length-1]

    let alternatingCharacters (testString : string) =
        let testStringWithOnlyAlternatingCharacters = getAlternatingCharacterString testString
        testString.Length - testStringWithOnlyAlternatingCharacters.Length

    ////Attempt 2
    //let rec getAlternatingCharacterString (c : char) (testString : string ) : string = 
    //    if testString.Length = 0 then
    //        c.ToString()
    //    elif c = testString.[0] then
    //        getAlternatingCharacterString c testString.[1..testString.Length-1]
    //    else
    //        c.ToString() + getAlternatingCharacterString testString.[0] testString.[1..testString.Length-1]

    //let alternatingCharacters (testString : string) =
    //    let testStringWithOnlyAlternatingCharacters = getAlternatingCharacterString testString.[0] testString.[1..testString.Length-1]
    //    testString.Length - testStringWithOnlyAlternatingCharacters.Length
        
    //Attempt 1
    //let alternatingCharacters (name : string) =
        //let mutable count = 0
        //let mutable previousCharToCheck = name.[0]

        //for i in 1..name.Length-1 do
        //    let newChar = name.[i]
        //    if previousCharToCheck = newChar then
        //        count <- count+1
        //    else
        //        previousCharToCheck <- newChar
        //count