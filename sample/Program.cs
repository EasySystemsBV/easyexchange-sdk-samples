using EasyExchange.Sdk.Core.Sample.SalesInvoices;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.Sample.PeppolDocuments;

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
            MainAsync().Wait();

        }

        static async Task MainAsync()
        {
            Client client = new Client(ENDPOINT_URL, CLIENT_ID, CLIENT_SECRET);
            await client.Authenticate(USERNAME, PASSWORD);
            Classify.Execute(client);
        }
    }
}