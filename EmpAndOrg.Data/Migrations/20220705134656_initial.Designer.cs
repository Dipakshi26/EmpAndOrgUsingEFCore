﻿// <auto-generated />
using System;
using EmpAndOrg.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmpAndOrg.Data.Migrations
{
    [DbContext(typeof(DemoDBContext))]
    [Migration("20220705134656_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmpAndOrg.Data.Entities.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Name")
                        .HasColumnType("Varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmpAndOrg.Data.Entities.Organisation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("OrgName")
                        .HasColumnType("Varchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("EmpAndOrg.Data.Entities.Organisation", b =>
                {
                    b.HasOne("EmpAndOrg.Data.Entities.Employee", "Employee")
                        .WithMany("OrganisationList")
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmpAndOrg.Data.Entities.Employee", b =>
                {
                    b.Navigation("OrganisationList");
                });
#pragma warning restore 612, 618
        }
    }
}