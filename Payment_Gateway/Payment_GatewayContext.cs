using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;
using Payment_Gateway.Models;
using System.Configuration;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class Payment_GatewayContext : DbContext
{
    private readonly IConfiguration _configuration;
    internal object Transaction;

    public Payment_GatewayContext(DbContextOptions<Payment_GatewayContext> options) : base(options)
    {
    }

    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder.UseSqlServer("Server=MARCIE;Database=PaymentGateway.Data; Integrated Security=True;");
    }
    // In Startup.cs or similar configuration file

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Transaction>(ConfigureProfile);
    }

    private void ConfigureProfile(EntityTypeBuilder<Transaction> builder)
    {
       
        builder.OwnsOne(p => p.Sender);
        builder.OwnsOne(p => p.Receiver);
    }

}