namespace Automated

module ApiCheck =
    open System
    open Automated.Types
    
    type TestWithMethod(uri: Uri, method: string) =
        member private this.Uri: Uri = uri

        member private this.Method:string = method

        member this.WithPayload (payload: string): IRequest =
            match this.Method with 
                | "GET" ->  WithQueryString (this.Uri, this.Method, payload) :> IRequest
                | "DELETE" ->  WithQueryString (this.Uri, this.Method, String.Empty) :> IRequest
                | _ -> WithBody (this.Uri, this.Method, payload) :> IRequest

        member this.Execute (): IRequest =
            this.WithPayload ""

    type Test(baseUri: Uri) = 
        member private this.baseUri = baseUri
        member this.WithMethod (method:string) =
            TestWithMethod (this.baseUri, method)

    let WithUri (baseUrl:Uri) = 
        Test (baseUrl)

    let WithString (baseUrl:string) =
        WithUri (new Uri(baseUrl))
