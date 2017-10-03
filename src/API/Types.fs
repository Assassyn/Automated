namespace Automated

module Types =
    open System
    open System.Net.Http

    type Response(code:string, body:string) =
        member this.HttpStatusCode = code
        member this.Body = body
    
    type IRequest =
        abstract member Execute: unit -> Response


    type WithQueryString(uri: Uri, method: string, queryString: string) =
        interface IRequest with 
            member this.Execute (): Response = 
                let response = async {
                    let client = HttpClient()
                    let response = client.GetAsync("http://www.contoso.com/");
                    let responseBody = response.Content.ReadAsStringAsync();
                    {200, responseBody}
                }
                //    new HttpClient()
                //client.
                Response ("", "")

    type WithBody(uri: Uri, method: string, body: string) =
        interface IRequest with 
            member this.Execute (): Response = 
                 Response ("", "")
