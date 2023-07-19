﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Payment_Gateway.Migrations
{
    [DbContext(typeof(Payment_GatewayContext))]
    [Migration("20230718070250_ReceiverChange")]
    partial class ReceiverChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Payment_Gateway.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Payment_Gateway.Models.Transaction", b =>
                {
                    b.OwnsOne("Payment_Gateway.Models.Receiver", "Receiver", b1 =>
                        {
                            b1.Property<int>("TransactionId")
                                .HasColumnType("int");

                            b1.Property<string>("Dst_Acc")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ID_NO")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.OwnsOne("Payment_Gateway.Models.Sender", "Sender", b1 =>
                        {
                            b1.Property<int>("TransactionId")
                                .HasColumnType("int");

                            b1.Property<string>("ID_NO")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Id")
                                .HasColumnType("int");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Src_Acc")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.Navigation("Receiver")
                        .IsRequired();

                    b.Navigation("Sender")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
