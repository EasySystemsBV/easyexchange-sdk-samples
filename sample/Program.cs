using EasyExchange.Sdk.Core.Sample.SalesInvoices;

namespace EasyExchange.Sdk.Core.Sample
{
    class Program
    {
        private const string ENDPOINT_URL = "https://easyexchange-partners.es-prd.net";
        private const string CLIENT_ID = "CLIENT";
        private const string CLIENT_SECRET = "SECRET";
        private const string USERNAME = "customer";
        private const string PASSWORD = "password";

        static void Main(string[] args)
        {
            Client client = new Client(ENDPOINT_URL, CLIENT_ID, CLIENT_SECRET);
            client.Authenticate( USERNAME, PASSWORD ).Wait();

            GetInvoices.Execute( client );
        }
    }
}