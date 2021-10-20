﻿// <auto-generated />
using Airtel1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airtel1.Migrations
{
    [DbContext(typeof(sampleDbcontext))]
    partial class sampleDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airtel1.Models.International", b =>
                {
                    b.Property<int>("Inid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amt")
                        .HasColumnType("int");

                    b.Property<string>("Descrip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("validity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Inid");

                    b.ToTable("internationals");
                });

            modelBuilder.Entity("Airtel1.Models.PhoneRecharge", b =>
                {
                    b.Property<int>("PRid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amt")
                        .HasColumnType("int");

                    b.Property<string>("Descrip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("validity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PRid");

                    b.ToTable("phoneRecharges");
                });

            modelBuilder.Entity("Airtel1.Models.RoamingPlan", b =>
                {
                    b.Property<int>("Rid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amt")
                        .HasColumnType("int");

                    b.Property<string>("Descrip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("validity")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Rid");

                    b.ToTable("RoamingPlans");
                });

            modelBuilder.Entity("Airtel1.Models.Users", b =>
                {
                    b.Property<string>("Pno")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pno");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
