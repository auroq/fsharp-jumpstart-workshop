namespace fsharp_jumpstart_worskhop.Logic

open System
open fsharp_jumpstart_workshop.Types

module MemberName = 
    let capitalizeFirstLetter (name : string) : string =
        name.[0].ToString().ToUpper() + name.[1..]

    let trim (name : string) : string =
        name.Trim()

    let toLower (name : string) : string =
        name.ToLower()

    let removeEmptySpaces (name : string) : string =
        name.Replace(" ", "")        

    let format (name : string) : string = capitalizeFirstLetter (removeEmptySpaces name)
