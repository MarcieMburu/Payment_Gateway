using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Payment_Gateway.Models;

namespace Payment_Gateway.Data
{
    public class Payment_GatewayContext : DbContext
    {
        public Payment_GatewayContext (DbContextOptions<Payment_GatewayContext> options)
            : base(options)
        {
        }

        public DbSet<Payment_Gateway.Models.Receiver> Receiver { get; set; } = default!;

        public DbSet<Payment_Gateway.Models.Sender>? Sender { get; set; }

        public DbSet<Payment_Gateway.Models.Transaction>? Transaction { get; set; }
    }
}
