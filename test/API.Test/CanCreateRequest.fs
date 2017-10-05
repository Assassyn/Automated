namespace Automated.API.Test

module CanCreateRequest = 
    open System
    open Xunit
    open FsUnit.Xunit

    [<Theory>]
    [<InlineData("GET", "WithQueryString")>]
    [<InlineData("POST", "WithBody")>]
    [<InlineData("PUT", "WithBody")>]
    [<InlineData("DELETE", "WithQueryString")>]
    let ``Request is crated for every HTTP word`` (httpWord: string, resultType: string) =
        let request = Automated.Api.ApiCall.WithString("https://testwebhooks.com/c/Automated.ApiCheck").WithMethod(httpWord).WithPayload("{property:'test'}")

        request.GetType().Name |> should equal resultType