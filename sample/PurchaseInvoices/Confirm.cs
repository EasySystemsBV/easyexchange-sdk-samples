using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.PurchaseInvoices.Models.Confirm;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices
{
    internal static class Confirm
    {
        internal static async Task Execute(Client client)
        {
            MarkDocumentDeliveredCommand command = new MarkDocumentDeliveredCommand
            {
                Reference = Guid.NewGuid().ToString()
            };

            await client.PurchaseInvoices.ConfirmDocumentAsync(command);
        }
    }
}