using Microsoft.EntityFrameworkCore;
using Payment_Gateway.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Payment_Gateway.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Payment_GatewayContext(
                serviceProvider.GetRequiredService<
                       DbContextOptions<Payment_GatewayContext>>()))
            {
              
                if (context.Sender.Any())
                {
                    return;   // DB has been seeded
                }
                context.Sender.AddRange(
                    new Sender
                    {
                        Sen_Name = "Mercy",
                        Sen_ID_NO = 87654321,
                        Sen_Phone = 0787654321,
                        Sen_Src_Acc = "Mpesa",


                    }
                );
                context.SaveChanges();
            }
        }
    }
}
