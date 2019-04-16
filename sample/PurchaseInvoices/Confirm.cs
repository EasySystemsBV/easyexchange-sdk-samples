﻿using System;
using System.Threading.Tasks;
using EasyExchange.Sdk.Core.PurchaseInvoices.Models.Confirm;

namespace EasyExchange.Sdk.Core.Sample.PurchaseInvoices
{
    internal class Confirm
    {
        internal static void Execute(Client client)
        {
            MarkDocumentDeliveredCommand command = new MarkDocumentDeliveredCommand
            {
                Reference = Guid.NewGuid().ToString()
            };

            Task task = Task.Run(
                    async () => await client.PurchaseInvoices.ConfirmDocumentAsync(command));
            Console.WriteLine($"Status: ", task.Status);
        }
    }
}