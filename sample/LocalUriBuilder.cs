namespace EasyExchange.Sdk.Sample {
    internal class LocalUriBuilder : IUrlBuilder
    {
        public string IdentityServerUrl()
        {
            return "http://localhost:30927";
        }

        public string SalesInvoiceServerUrl()
        {
            return "http://localhost:30618";
        }
    }
}