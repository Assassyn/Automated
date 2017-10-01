namespace Automated

module Types =
    open System
    
    type IRequest =
        abstract member Execute: unit -> string

    type WithQueryString(uri: Uri, method: string, queryString: string) =
        interface IRequest with 
            member this.Execute (): string = 
                 String.Empty

    type WithBody(uri: Uri, method: string, body: string) =
        interface IRequest with 
            member this.Execute (): string = 
                 String.Empty
