namespace Automated.API.Test

module SimpleQueryReturnsResults = 
    open System
    open Xunit
    open FsUnit.Xunit

    [<Fact>]
    let ``When execute get request the response code is 200`` (httpWord: string, resultType: string) =
        let request = Automated
			.Api
			.ApiCall
			.WithString("https://testwebhooks.com/c/Automated.ApiCheck")
			.WithMethod(httpWord)
			.WithPayload("{property:'test'}")

        request.GetType().Name |> should equal resultType