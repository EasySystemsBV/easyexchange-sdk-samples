using EasyExchange.Sdk.Core.Sample.SalesInvoices;

namespace EasyExchange.Sdk.Core.Sample
{
    class Program
    {
        private const string ENDPOINT_URL = "https://easyexchange-partners.es-prd.net";
        private const string CLIENT_ID = "IDYN";
        private const string CLIENT_SECRET = "yjCJu2Xo8C3zjwynDpZfS8LT4lGVxMD1d2lu7G1c";
        private const string USERNAME = "idyn";
        private const string PASSWORD = "$2b$12$xbMrATn7CSxDVqlag9MEO.pdfEoH201OuX4gWnLrULvuysXtHrVaq";

        static void Main(string[] args)
        {
            Client client = new Client(ENDPOINT_URL, CLIENT_ID, CLIENT_SECRET, EasyExchangeScope.SalesInvoices);
            client.Authenticate( USERNAME, PASSWORD ).Wait();

            GetInvoices.Execute( client );
        }
    }
}