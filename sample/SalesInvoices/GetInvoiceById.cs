using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.GetInvoiceById;

namespace EasyExchange.Sdk.Core.Sample.SalesInvoices
{
    internal class GetInvoiceById
    {
        internal static void Execute(Client client)
        {
            Guid id = Guid.NewGuid();

            Task<GetInvoiceByIdResponse> task = Task.Run(
                async () => await client.SalesInvoices.GetInvoiceByIdAsync(id));
            Console.WriteLine($"SendStatus: ", task.Result.SendStatus);
        }
    }
}