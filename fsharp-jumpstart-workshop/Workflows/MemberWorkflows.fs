namespace fsharp_jumpstart_workshop.Workflows

open System
open fsharp_jumpstart_workshop.Types
open fsharp_jumpstart_workshop.Logic

module MemberWorkflows =

    let getAll 
        ( getAllMembers : unit -> Member list )
        =
            getAllMembers

    let findById
        (findById : int -> Member option)
        (id : int)
        =
            findById id  

    let findByEmail 
        (findByEmail : string -> Member option)
        (email : string)
        =
            findByEmail email

    let save
        (save : Member -> unit)
        (firstName : string)
        (lastName : string)
        (email : string)
        (planId : string)
        =
            match Validation.validateEmail (UnvalidatedEmail email) with
            | Ok (ValidatedEmail validatedEmail) -> 
                let memberToSave = { Id = Random().Next(); FirstName = firstName; LastName = lastName; Email = validatedEmail; PlanId = planId}
                save memberToSave
                Ok ()  
            | Error err ->
                Error err

    let updateEmail
        (updateEmail : int -> string -> unit)
        (id : int)
        (email : string)
        =
            match Validation.validateEmail (UnvalidatedEmail email) with
            | Ok (ValidatedEmail validatedEmail) ->
                updateEmail id validatedEmail
                Ok ()  
            | Error err ->
                Error err
