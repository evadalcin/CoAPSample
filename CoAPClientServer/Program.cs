
Console.WriteLine("Seleziona modalità:");
Console.WriteLine("1. Server");
Console.WriteLine("2. Client");

string input = Console.ReadLine();

if (input == "1")
{
    RunServer();
}
else if (input == "2")
{
    RunClient();
}
else
{
    Console.WriteLine("Selezione non valida");
}


static void RunServer()
{
    Server server = new Server();
    server.Start();

    Console.WriteLine("Premi un tasto per terminare il server...");
    Console.ReadKey();

    server.Stop();
}

static void RunClient()
{
    Client client = new Client();

    Console.WriteLine("Test GET request...");
    string getResponse = client.SendGet();
    Console.WriteLine($"Risposta GET: {getResponse}");

    Console.WriteLine("\nTest POST request...");
    string postResponse = client.SendPost("Test messaggio");
    Console.WriteLine($"Risposta POST: {postResponse}");

    Console.WriteLine("\nPremi un tasto per terminare il client...");
    Console.ReadKey();
}
