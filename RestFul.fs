namespace SuaveRestApi.Rest
[<AutoOpen>]
module RestFul =
  type RestResource<'a> = {
   GetAll : unit -> 'a seq
  let rest resourceName resource =
  let resourcePath = "/" + resourceName
  let gellAll = resource.GetAll () |> JSON
  path resourcePath >=> GET >=> getAll
  }




  let JSON v =
  let jsonSerializerSettings = new JsonSerializerSettings()
  jsonSerializerSettings.ContractResolver <- new CamelCasePropertyNamesContractResolver()

  JsonConvert.SerializeObject(v, jsonSerializerSettings)
  |> OK
  >=> Writers.setMimeType "application/json; charset=utf-8"
  