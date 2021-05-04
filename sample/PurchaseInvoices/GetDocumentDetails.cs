using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.PurchaseInvoices.Models.GetDocumentDetails;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices {
    internal static class GetDocumentDetails
    {
        internal static async Task Execute(Client client)
        {
            string documentReference = Guid.NewGuid().ToString();

            GetDocumentResponse result = await client.PurchaseInvoices.GetDocumentDetailsAsync(documentReference);
            Console.WriteLine($"Reference: ", result.Reference);

            var xmlResult = await client.PurchaseInvoices.Xml(documentReference);
            string xml = xmlResult.Content.ToString();
            Console.WriteLine($"Xml: ", xml);
        }
    }
}