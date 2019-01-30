open SuaveRestApi.Rest
open SuaveRestApi.Db
open Suave.Web
open Suave.Http.Successful

[<EntryPoint>]
let main argv =
  let personWebPart = rest "people" {
    GetAll = Db.getPeople
  }
  startWebServer defaultConfig personWebPart
  0