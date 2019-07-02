using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices {
    internal static class GetNewDocuments
    {
        internal static async Task Execute(Client client)
        {
            List<string> result = await client.PurchaseInvoices.GetNewDocumentsAsync();
            Console.WriteLine($"Items: ", result.Count);
        }
    }
}