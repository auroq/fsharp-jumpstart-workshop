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
            let isEmailOk = Validation.validateEmail email
            if isEmailOk then
                let memberToSave = { Id = Random().Next(); FirstName = firstName; LastName = lastName; Email = email; PlanId = planId}
                save memberToSave   
                true 
            else
                false

