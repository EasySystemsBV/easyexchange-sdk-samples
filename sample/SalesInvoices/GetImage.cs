using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.GetImage;

namespace EasyExchange.Sdk.Core.Sample.SalesInvoices {
    internal class GetImage
    {
        internal static void Execute(Client client)
        {
            Guid id = Guid.NewGuid();

            Task<SalesInvoiceImageResponse> task = Task.Run(
                async () => await client.SalesInvoices.GetImageAsync(id));
            Console.WriteLine($"ContentType: ", task.Result.ContentType);
            Console.WriteLine($"FileName: ", task.Result.FileName);
            Console.WriteLine($"DataUri: ", task.Result.DataUri);
        }
    }
}