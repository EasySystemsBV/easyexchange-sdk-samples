using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.SmpLookup.Models.Find;

namespace EasyExchange.Sdk.Core.Sample.SmpLookup
{
    internal static class Find
    {
        internal static async Task Execute(Client client)
        {
            const string code = "0106";
            const string value = "09160948";
            FindResponse result = await client.SmpLookup.FindAsync(code, value);
            Console.WriteLine($"Exists: ", result.Exists);
            Console.WriteLine($"#Supported Documents: ", result.Participant.SupportedDocuments.Count);
        }
    }
}