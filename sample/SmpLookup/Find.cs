using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SalesInvoices.Models.GetImage;
using EasyExchange.Sdk.Core.SmpLookup.Models.Find;

namespace EasyExchange.Sdk.Core.Sample.SmpLookup
{
    internal class Find
    {
        internal static void Execute(Client client)
        {
            const string code = "0106";
            const string value = "09160948";
            Task<FindResponse> task = Task.Run(
                async () => await client.SmpLookup.FindAsync(code, value));
            Console.WriteLine($"Exists: ", task.Result.Exists);
            Console.WriteLine($"#Supported Documents: ", task.Result.Participant.SupportedDocuments.Count);
        }
    }
}