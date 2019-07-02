using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.PostInvoice;

namespace EasyExchange.Sdk.Core.Sample.SalesInvoices {
    internal static class PostInvoice
    {
        internal static async Task Execute(Client client)
        {
            PostSalesInvoice invoiceToPost = new PostSalesInvoice();
            invoiceToPost.Receiver.Name = "Company BV";
            invoiceToPost.Receiver.EmailAddress = "info@example.com";
            invoiceToPost.Image.FileName = "invoice.pdf";
            invoiceToPost.Image.ContentType = "application/pdf";
            invoiceToPost.Image.Base64Content = "<BASE64GOESHERE>";
            PostSalesInvoiceResponse result = await client.SalesInvoices.PostAsync(invoiceToPost);
            Console.WriteLine($"Invoice ID: ", result.Id);
        }
    }
}