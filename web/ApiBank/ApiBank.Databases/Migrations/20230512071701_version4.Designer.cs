﻿// <auto-generated />
using System;
using ApiBank.Databases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiBank.Databases.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20230512071701_version4")]
    partial class version4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiBank.Models.BankTransaction", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<decimal?>("TransactionAmount")
                        .IsRequired()
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)")
                        .HasColumnName("transaction_amount");

                    b.Property<DateTime?>("TransactionDate")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("transaction_date");

                    b.Property<long>("TransactionFrom")
                        .HasColumnType("bigint")
                        .HasColumnName("transeaction_from");

                    b.Property<long>("TransactionTo")
                        .HasColumnType("bigint")
                        .HasColumnName("transaction_to");

                    b.HasKey("Id");

                    b.ToTable("BankTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}