namespace Automated

module Types =
    open System

    type Response(code:string, body:string) =
        member this.HttpStatusCode = code
        member this.Body = body
    
    type IRequest =
        abstract member Execute: unit -> Response


    type WithQueryString(uri: Uri, method: string, queryString: string) =
        interface IRequest with 
            member this.Execute (): Response = 
                 Response ("", "")

    type WithBody(uri: Uri, method: string, body: string) =
        interface IRequest with 
            member this.Execute (): Response = 
                 Response ("", "")
