﻿// <auto-generated />
using System;
using GrpcServiceOnlineBanking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GrpcServiceOnlineBanking.Migrations
{
    [DbContext(typeof(HungDbContext))]
    [Migration("20240801045605_bank01")]
    partial class bank01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.AccountCustomer", b =>
                {
                    b.Property<int>("AccountId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("AccountId", "CustomerId");

                    b.HasIndex("AccountId", "CustomerId")
                        .IsUnique();

                    b.ToTable("AccountCustomers");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.AccountType", b =>
                {
                    b.Property<string>("TypeOfAccount")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal>("MinimumBalanceRestriction")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("TypeOfAccount");

                    b.HasIndex("TypeOfAccount")
                        .IsUnique();

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.Accounts", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<decimal>("AccountBalance")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("BranchId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOpen")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeOfAccount")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AccountId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Accountss");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.BankingTransactions", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("CustomerId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("TransactionId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("BankingTransactions");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.BranchEmployee", b =>
                {
                    b.Property<int>("BranchId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BranchId", "EmployeeId");

                    b.HasIndex("BranchId", "EmployeeId")
                        .IsUnique();

                    b.ToTable("BranchEmployees");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.Branches", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchId"));

                    b.Property<string>("BranchName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("StreesAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("BranchId");

                    b.HasIndex("BranchId")
                        .IsUnique();

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.CreditCard", b =>
                {
                    b.Property<string>("CreditCardNumber")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("CreditScore")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MaximumLimit")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("CreditCardNumber");

                    b.HasIndex("CreditCardNumber")
                        .IsUnique();

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.CreditCardTransactions", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Merchant")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("TransctionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("CreditCardTransactionss");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("StreesAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("LevelOfAccess")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("StreesAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SupervisorId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("GrpcServiceOnlineBanking.Models.Loan", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanId"));

                    b.Property<int>("CustomerId")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<decimal>("DurationInYear")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("InterestRate")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("LoanAmountRepaid")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<decimal>("LoanAmountTaken")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("LoanStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoanType")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("LoanId");

                    b.HasIndex("LoanId")
                        .IsUnique();

                    b.ToTable("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
