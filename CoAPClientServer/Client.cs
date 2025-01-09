using CoAP;

public class Client
{
    private string serverUrl;

    public Client(string host = "localhost", int port = 5683)
    {
        serverUrl = $"coap://{host}:{port}/hello";
    }

    public string SendGet()
    {
        Request request = new Request(Method.GET);
        request.URI = new Uri(serverUrl);
        request.Send();

        Response response = request.WaitForResponse();
        return response?.PayloadString ?? "Nessuna risposta ricevuta";
    }

    public string SendPost(string message)
    {
        Request request = new Request(Method.POST);
        request.URI = new Uri(serverUrl);
        request.SetPayload(message);
        request.Send();

        Response response = request.WaitForResponse();
        return response?.PayloadString ?? "Nessuna risposta ricevuta";
    }
}
