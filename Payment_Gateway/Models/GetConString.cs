using Microsoft.Extensions.Configuration;
using System.IO;

namespace Payment_Gateway.Models
{
    
        public static class GetConString
        {
            public static string ConString()
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                var config = builder.Build();
                string constring = config.GetConnectionString("PaymentGateway.Data");
                return constring;
            }
        }
}
