namespace SuaveRestApi.Db
open System.Collections.Generic
type Person = {
  Id : int
  Name : string
  Age : int
  Email : string
}
module Db =
  let private peopleStorage = new Dictionary<int, Person>()
  let getPeople () =
    peopleStorage.Values |> Seq.map (fun p -> p)
