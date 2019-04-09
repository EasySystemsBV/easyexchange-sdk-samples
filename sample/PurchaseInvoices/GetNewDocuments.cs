using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyExchange.Sdk.Sample.PurchaseInvoices {
    internal class GetNewDocuments
    {
        internal static void Execute(Client client)
        {
            Guid id = Guid.NewGuid();

            Task<List<string>> task = Task.Run(
                async () => await client.PurchaseInvoices.GetNewDocumentsAsync());
            Console.WriteLine($"Items: ", task.Result.Count);
        }
    }
}