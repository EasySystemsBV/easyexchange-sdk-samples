using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices {
    internal class GetNewDocuments
    {
        internal static void Execute(Client client)
        {
            Task<List<string>> task = Task.Run(
                async () => await client.PurchaseInvoices.GetNewDocumentsAsync());
            Console.WriteLine($"Items: ", task.Result.Count);
        }
    }
}