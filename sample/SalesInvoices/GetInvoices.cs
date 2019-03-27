using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.SalesInvoices.Models.GetInvoices;

namespace EasyExchange.Sdk.Sample.SalesInvoices
{
    internal class GetInvoices
    {
        internal static void Execute(Client client)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            Task<GetInvoicesResponse> task = Task.Run(
                async () => await client.SalesInvoices.GetInvoicesAsync(startDate, null));
            foreach (GetInvoice invoice in task.Result.Data)
            {
                Console.WriteLine($"Invoice ID: ", invoice.Identifier);
            }
        }
    }
}