using System;
using System.Threading.Tasks;
using EasyExchange.SalesInvoiceServer.Sdk.Models.PostInvoiceXml;

namespace EasyExchange.Sdk.Sample.SalesInvoices {
    internal class PostInvoiceXml
    {
        internal static void Execute(Client client)
        {
            PostSalesInvoiceXml invoiceToPost = new PostSalesInvoiceXml();
            invoiceToPost.Receiver.Name = "Company BV";
            invoiceToPost.Receiver.EmailAddress.Name= "John Doe";
            invoiceToPost.Receiver.EmailAddress.Address = "info@example.com";
            invoiceToPost.Xml = "<YOUR_INVOICE_XML_GOES_HERE/>";
            invoiceToPost.Image.FileName = "invoice.pdf";
            invoiceToPost.Image.ContentType = "application/pdf";
            invoiceToPost.Image.Base64Content = "<BASE64GOESHERE>";
            Task<PostSalesInvoiceXmlResponse> task = Task.Run(
                async () => await client.SalesInvoices.PostXmlAsync(invoiceToPost));
            Console.WriteLine($"Invoice ID: ", task.Result.Id);
        }
    }
}