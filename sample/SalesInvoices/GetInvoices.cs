using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.GetInvoices;

namespace EasyExchange.Sdk.Core.Sample.SalesInvoices
{
    internal static class GetInvoices
    {
        internal static async Task Execute(Client client)
        {
            DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            GetInvoicesResponse result = await client.SalesInvoices.GetInvoicesAsync(startDate, null);
            foreach (GetInvoice invoice in result.Data)
            {
                Console.WriteLine($"Invoice ID: ", invoice.Identifier);
            }
        }
    }
}