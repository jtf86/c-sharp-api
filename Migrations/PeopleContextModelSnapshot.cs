﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestApiProject.Models;

namespace TestApiProject.Migrations
{
    [DbContext(typeof(PeopleContext))]
    partial class PeopleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TestApiProject.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PersonId");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.HasIndex("PersonId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("TestApiProject.Models.AnimalColor", b =>
                {
                    b.Property<int>("AnimalId");

                    b.Property<int>("ColorId");

                    b.HasKey("AnimalId", "ColorId");

                    b.HasAlternateKey("AnimalId");

                    b.HasIndex("ColorId");

                    b.ToTable("AnimalColor");
                });

            modelBuilder.Entity("TestApiProject.Models.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("TestApiProject.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("TestApiProject.Models.Animal", b =>
                {
                    b.HasOne("TestApiProject.Models.Person", "Person")
                        .WithMany("Animals")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TestApiProject.Models.AnimalColor", b =>
                {
                    b.HasOne("TestApiProject.Models.Animal", "Animal")
                        .WithMany("AnimalColors")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TestApiProject.Models.Color", "Color")
                        .WithMany("AnimalColors")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
