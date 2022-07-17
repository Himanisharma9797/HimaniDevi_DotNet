﻿// <auto-generated />
using Billing.Service.DAL.AmountDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Billing.Service.DAL.Migrations
{
    [DbContext(typeof(AmountDbContext))]
    [Migration("20220630031335_thirdfMigration")]
    partial class thirdfMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Billing.Service.DAL.AmountDb.Amount", b =>
                {
                    b.Property<int>("BillingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CompletedHours")
                        .HasColumnType("float");

                    b.Property<int>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("TitleOfTaskToBeBilled")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalBillCalculated")
                        .HasColumnType("float");

                    b.HasKey("BillingId");

                    b.ToTable("Amounts");
                });
#pragma warning restore 612, 618
        }
    }
}
