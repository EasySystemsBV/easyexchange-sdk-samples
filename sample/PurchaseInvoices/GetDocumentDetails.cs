using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.PurchaseInvoices.Models.GetDocumentDetails;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices {
    internal class GetDocumentDetails
    {
        internal static void Execute(Client client)
        {
            string documentReference = Guid.NewGuid().ToString();

            Task<GetDocumentResponse> task = Task.Run(
                async () => await client.PurchaseInvoices.GetDocumentDetailsAsync(documentReference));
            Console.WriteLine($"PayloadXml: ", task.Result.PayloadXml);
        }
    }
}