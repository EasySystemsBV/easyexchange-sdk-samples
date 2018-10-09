using System;
using System.Threading.Tasks;
using EasyExchange.SalesInvoiceServer.Sdk.Models.PostInvoice;

namespace EasyExchange.Sdk.Sample.SalesInvoices {
    internal class PostInvoice
    {
        internal static void Execute(Client client)
        {
            PostSalesInvoice invoiceToPost = new PostSalesInvoice();
            invoiceToPost.Receiver.Name = "Company BV";
            invoiceToPost.Receiver.EmailAddress = "info@example.com";
            invoiceToPost.Image.FileName = "invoice.pdf";
            invoiceToPost.Image.ContentType = "application/pdf";
            invoiceToPost.Image.Base64Content = "<BASE64GOESHERE>";
            Task<PostSalesInvoiceResponse> task = Task.Run(
                async () => await client.SalesInvoices.PostAsync(invoiceToPost));
            Console.WriteLine($"Invoice ID: ", task.Result.Id);
        }
    }
}