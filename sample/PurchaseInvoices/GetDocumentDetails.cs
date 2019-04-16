using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.PurchaseInvoices.Models.GetDocumentDetails;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices {
    internal class GetDocumentDetails
    {
        internal static void Execute(Client client)
        {
            Guid id = Guid.NewGuid();

            Task<GetDocumentResponse> task = Task.Run(
                async () => await client.PurchaseInvoices.GetDocumentDetailsAsync(id));
            Console.WriteLine($"PayloadXml: ", task.Result.PayloadXml);
        }
    }
}