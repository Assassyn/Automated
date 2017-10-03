namespace Automated

module Types =
    open System
    open System.Net

    type Response(code:HttpStatusCode, body:string) =
        member this.HttpStatusCode = code
        member this.Body = body
    
    type IRequest =
        abstract member Execute: unit -> Response


    type WithQueryString(uri: Uri, method: string, queryString: string) =
        interface IRequest with 
            member this.Execute (): Response = 
                Response (HttpStatusCode.OK, "")

    type WithBody(uri: Uri, method: string, body: string) =
        interface IRequest with 
            member this.Execute (): Response = 
                Response (HttpStatusCode.OK, "")
