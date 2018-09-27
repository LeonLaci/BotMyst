﻿// <auto-generated />
using BotMyst.Web.DatabaseContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BotMyst.Web.Migrations
{
    [DbContext(typeof(ModuleDescriptionsContext))]
    partial class ModuleDescriptionsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("BotMyst.Web.Models.CommandDescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Command");

                    b.Property<int>("ModuleDescriptionID");

                    b.Property<string>("Summary");

                    b.HasKey("ID");

                    b.HasIndex("ModuleDescriptionID");

                    b.ToTable("CommandDescription");
                });

            modelBuilder.Entity("BotMyst.Web.Models.ModuleDescription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("ModuleDescriptions");
                });

            modelBuilder.Entity("BotMyst.Web.Models.CommandDescription", b =>
                {
                    b.HasOne("BotMyst.Web.Models.ModuleDescription", "ModuleDescription")
                        .WithMany("CommandDescriptions")
                        .HasForeignKey("ModuleDescriptionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}