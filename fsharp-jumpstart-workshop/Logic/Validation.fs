namespace fsharp_jumpstart_worskhop.Logic

open System
open fsharp_jumpstart_workshop.Types

module Validation =
    let validateEmail (email : string) : bool =
        email.Contains("@") &&
        email.Length > 2 &&
        email.IndexOf("@") = email.LastIndexOf("@") &&
        email.IndexOf("@") > 0 &&
        email.IndexOf("@") < (email.Length - 1)
