﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using ToolShed3.Models;

namespace ToolShed3.Migrations
{
    [DbContext(typeof(ToolShedContext))]
    [Migration("20180709213907_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToolShed.Models.Tool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SKU");

                    b.Property<DateTime>("acqDate");

                    b.Property<string>("brand");

                    b.Property<bool>("hasToolbox");

                    b.Property<string>("name");

                    b.Property<float>("price");

                    b.Property<string>("toolbox");

                    b.HasKey("ID");

                    b.ToTable("Tool");
                });
#pragma warning restore 612, 618
        }
    }
}