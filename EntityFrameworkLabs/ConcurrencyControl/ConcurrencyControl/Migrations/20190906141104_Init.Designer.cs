﻿// <auto-generated />
using System;
using ConcurrencyControl.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConcurrencyControl.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190906141104_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ConcurrencyControl.Models.ConcurrentAccountWithRowVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<double>("Balance")
                        .HasColumnName("Balance");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("Timestamp")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.ToTable("ConcurrentAccountsWithRowVersion");
                });

            modelBuilder.Entity("ConcurrencyControl.Models.ConcurrentAccountWithToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<double>("Balance")
                        .IsConcurrencyToken()
                        .HasColumnName("Balance");

                    b.HasKey("Id");

                    b.ToTable("ConcurrentAccountsWithToken");
                });

            modelBuilder.Entity("ConcurrencyControl.Models.NonconcurrentAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<double>("Balance")
                        .HasColumnName("Balance");

                    b.HasKey("Id");

                    b.ToTable("NonconcurrentAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
