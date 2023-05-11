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
    [Migration("20230511063745_version1")]
    partial class version1
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

                    b.Property<decimal?>("TransactionAmmount")
                        .IsRequired()
                        .HasPrecision(7, 2)
                        .HasColumnType("decimal(7,2)");

                    b.Property<DateTime?>("TransactionDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionFrom")
                        .HasColumnType("int");

                    b.Property<int>("TransectionTo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BankTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
