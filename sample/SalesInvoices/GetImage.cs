using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.GetImage;

namespace EasyExchange.Sdk.Core.Sample.SalesInvoices {
    internal static class GetImage
    {
        internal static async Task Execute(Client client)
        {
            Guid id = Guid.NewGuid();

            SalesInvoiceImageResponse result= await client.SalesInvoices.GetImageAsync(id);
            Console.WriteLine($"ContentType: ", result.ContentType);
            Console.WriteLine($"FileName: ", result.FileName);
            Console.WriteLine($"DataUri: ", result.DataUri);
        }
    }
}