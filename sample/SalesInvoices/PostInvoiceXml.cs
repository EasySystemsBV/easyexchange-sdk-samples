using System;
using System.IO;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.PostInvoiceXml;

namespace EasyExchange.Sdk.Core.Sample.SalesInvoices {
    internal class PostInvoiceXml
    {
        internal static void Execute(Client client)
        {
            byte[] AsBytes = File.ReadAllBytes(@"C:\Temp\SetupFeeInvoice.pdf");
            String AsBase64String = Convert.ToBase64String(AsBytes);
            String AsXml = File.ReadAllText(@"C:\Users\amaters\OneDrive - Innovestit Group bv\Development\Exchange Connector\deisis2easy_ubl-2.xml");

            PostSalesInvoiceXml invoiceToPost = new PostSalesInvoiceXml();
            invoiceToPost.Receiver.Name = "Company BV";
            invoiceToPost.Receiver.EmailAddress.Name= "John Doe";
            invoiceToPost.Receiver.EmailAddress.Address = "info@example.com";
            invoiceToPost.Receiver.PeppolAddress.Iso6523Code = "0106";
            invoiceToPost.Receiver.PeppolAddress.Iso6523Code = "KVKNUMBER";
            invoiceToPost.Receiver.PostalAddress.StreetName = "street"; // provide more information about postaladdress
            invoiceToPost.Xml = AsXml;
            
            invoiceToPost.Image.FileName = "invoice.pdf";
            invoiceToPost.Image.ContentType = "application/pdf";
            invoiceToPost.Image.Base64Content = AsBase64String;

            Task<PostSalesInvoiceXmlResponse> task = Task.Run(
                async () => await client.SalesInvoices.PostXmlAsync(invoiceToPost));
            Console.WriteLine($"Invoice ID: ", task.Result.Id);
        }
    }
}