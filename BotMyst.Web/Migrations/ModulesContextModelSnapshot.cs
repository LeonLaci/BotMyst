﻿// <auto-generated />
using BotMyst.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace BotMyst.Web.Migrations
{
    [DbContext(typeof(ModulesContext))]
    partial class ModulesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("BotMyst.Bot.Options.LmgtfyOptions", b =>
                {
                    b.Property<ulong>("Id");

                    b.Property<bool>("DeleteInvocationMessage");

                    b.Property<bool>("Dm");

                    b.Property<bool>("Enabled");

                    b.Property<string>("ExcludeChannels");

                    b.Property<string>("ExcludeRoles");

                    b.Property<string>("IncludeChannels");

                    b.Property<string>("IncludeRoles");

                    b.Property<bool>("InternetExplainer");

                    b.Property<string>("SearchEngine");

                    b.HasKey("Id");

                    b.ToTable("LmgtfyOptions");
                });

            modelBuilder.Entity("BotMyst.Bot.Options.UserInfoOptions", b =>
                {
                    b.Property<ulong>("Id");

                    b.Property<bool>("DeleteInvocationMessage");

                    b.Property<bool>("Dm");

                    b.Property<bool>("Enabled");

                    b.Property<string>("ExcludeChannels");

                    b.Property<string>("ExcludeRoles");

                    b.Property<string>("IncludeChannels");

                    b.Property<string>("IncludeRoles");

                    b.Property<bool>("ShowCreatedAt");

                    b.Property<bool>("ShowGame");

                    b.Property<bool>("ShowJoinedAt");

                    b.Property<bool>("ShowOnlineStatus");

                    b.Property<bool>("ShowRoles");

                    b.HasKey("Id");

                    b.ToTable("UserInfoOptions");
                });

            modelBuilder.Entity("BotMyst.Bot.Options.UtilityOptions", b =>
                {
                    b.Property<ulong>("Id");

                    b.Property<ulong?>("LmgtfyOptionsId");

                    b.Property<ulong?>("UserInfoOptionsId");

                    b.HasKey("Id");

                    b.HasIndex("LmgtfyOptionsId");

                    b.HasIndex("UserInfoOptionsId");

                    b.ToTable("UtilityOptions");
                });

            modelBuilder.Entity("BotMyst.Bot.Options.UtilityOptions", b =>
                {
                    b.HasOne("BotMyst.Bot.Options.LmgtfyOptions", "LmgtfyOptions")
                        .WithMany()
                        .HasForeignKey("LmgtfyOptionsId");

                    b.HasOne("BotMyst.Bot.Options.UserInfoOptions", "UserInfoOptions")
                        .WithMany()
                        .HasForeignKey("UserInfoOptionsId");
                });
#pragma warning restore 612, 618
        }
    }
}
