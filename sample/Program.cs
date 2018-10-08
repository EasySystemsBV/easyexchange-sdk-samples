using System;
using System.Threading.Tasks;
using EasyExchange.SalesInvoiceServer.Sdk.Models.GetInvoices;

namespace EasyExchange.Sdk.Sample
{
    class Program
    {
        //private const string ENDPOINT_URL = "https://easyexchange.es-dev.net";
        private const string ENDPOINT_URL = "http://localhost:30927";
        private const string CLIENT_ID = "CLIENT_ID";
        private const string CLIENT_SECRET = "CLIENT_SECRET";
        private const string USERNAME = "username";
        private const string PASSWORD = "password";

        static void Main(string[] args)
        {
            Client client = new Client(ENDPOINT_URL, CLIENT_ID, CLIENT_SECRET, EasyExchangeScope.SalesInvoiceServer);
            //Client client = new Client(CLIENT_ID, CLIENT_SECRET, EasyExchangeScope.SalesInvoiceServer, new LocalUriBuilder());
            client.Authenticate( USERNAME, PASSWORD ).Wait();

            string emailAddress ="name@example.com";
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month,1) ;

            Task<GetInvoicesResponse> task = Task.Run(
                async () => await client.SalesInvoices.GetInvoicesAsync( emailAddress, startDate, null ) );
            foreach( GetInvoice invoice in task.Result.Data )
            {
                Console.WriteLine( $"Invoice ID: ", invoice.Identifier );
            }
        }
    }
}