using EasyExchange.Sdk.Sample.SalesInvoices;

namespace EasyExchange.Sdk.Sample
{
    class Program
    {
        private const string ENDPOINT_URL = "https://easyexchange-partners.es-prd.net";
        private const string CLIENT_ID = "CLIENT_ID";
        private const string CLIENT_SECRET = "CLIENT_SECRET";
        private const string USERNAME = "username";
        private const string PASSWORD = "password";

        static void Main(string[] args)
        {
            Client client = new Client(ENDPOINT_URL, CLIENT_ID, CLIENT_SECRET, EasyExchangeScope.SalesInvoices);
            client.Authenticate( USERNAME, PASSWORD ).Wait();

            GetInvoices.Execute( client );
        }
    }
}