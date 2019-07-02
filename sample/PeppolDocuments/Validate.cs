using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.PeppolDocuments.Models;

namespace EasyExchange.Sdk.Core.Sample.PeppolDocuments
{
    internal static class Validate
    {
        internal static async Task Execute(Client client)
        {
            ValidateCommand command = new ValidateCommand
            {
                Base64Xml = "Base64Xml"
            };
            ValidateResponse result = await client.PeppolDocuments.ValidateAsync(command);
            Console.WriteLine($"Is valid: ", result.IsValid);
        }
    }
}