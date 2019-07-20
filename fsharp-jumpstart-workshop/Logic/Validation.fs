namespace fsharp_jumpstart_workshop.Logic

open System
open fsharp_jumpstart_workshop.Types

module Validation =
    let validateEmail (UnvalidatedEmail email) : Result<ValidatedEmail, EmailValidationError> =
        match (email, email.Split("@")) with
        | email, _ when email.Length < 3 -> Error TooShort
        | _, arrayOfWords when arrayOfWords.Length <> 2 -> Error BadAtCount
        | _, [|word1; word2|] when word1.Length = 0 || word2.Length = 0 -> Error NoTextOnSidesOfAt
        | _ -> Ok (ValidatedEmail email)
