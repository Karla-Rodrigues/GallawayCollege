﻿// <auto-generated />
using KarlaR_300997958.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KarlaR_300997958.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190709120527_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KarlaR_300997958.Models.Faculty", b =>
                {
                    b.Property<int>("FacultyCode")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FacultyEMail")
                        .IsRequired();

                    b.Property<string>("FacultyName")
                        .IsRequired();

                    b.Property<string>("FacultySurname")
                        .IsRequired();

                    b.HasKey("FacultyCode");

                    b.ToTable("Faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
