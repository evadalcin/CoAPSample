using CoAP.Server;
using CoAP.Server.Resources;

    public class Server
    {
        private CoapServer coapServer;

        public Server(int port = 5683)
        {
            coapServer = new CoapServer(port);
            coapServer.Add(new HelloResource());
        }

        public void Start()
        {
            coapServer.Start();
            Console.WriteLine($"Server CoAP avviato sulla porta {coapServer.Config.HttpPort}");
        }

        public void Stop()
        {
            coapServer.Stop();
            Console.WriteLine("Server CoAP fermato");
        }
    }

    public class HelloResource : Resource
    {
        public HelloResource() : base("hello")
        {
            Attributes.Title = "Hello Resource";
            Attributes.AddResourceType("Hello");
        }

        protected override void DoGet(CoapExchange exchange)
        {
            exchange.Respond("Hello from CoAP Server");
        }

        protected override void DoPost(CoapExchange exchange)
        {
            string receivedData = exchange.Request.PayloadString;
            Console.WriteLine($"Ricevuto: {receivedData}");
            exchange.Respond($"Hai inviato: {receivedData}");
        }
    }
