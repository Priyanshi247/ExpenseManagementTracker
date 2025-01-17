﻿// <auto-generated />
using System;
using ExpenseManagement.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpenseManagement.Migrations
{
    [DbContext(typeof(DbContextExpMgt))]
    [Migration("20240905115501_AddedForeignKeyToExpenseEntity")]
    partial class AddedForeignKeyToExpenseEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExpenseManagement.Models.ExpenseCategoryEntity", b =>
                {
                    b.Property<int>("ExpenseCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseCategoryId"));

                    b.Property<string>("ExpenseCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseCategoryId");

                    b.ToTable("ExpenseCategory");
                });

            modelBuilder.Entity("ExpenseManagement.Models.ExpenseEntity", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpenseId"));

                    b.Property<double>("ExpenseAmount")
                        .HasColumnType("float");

                    b.Property<int>("ExpenseCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpenseGivenTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseId");

                    b.HasIndex("ExpenseCategoryId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("ExpenseManagement.Models.ExpenseEntity", b =>
                {
                    b.HasOne("ExpenseManagement.Models.ExpenseCategoryEntity", "ExpenseCategory")
                        .WithMany()
                        .HasForeignKey("ExpenseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExpenseCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
