﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VolleyballApp.API.Data;

namespace VolleyballApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201029134538_StartOnInvites")]
    partial class StartOnInvites
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("TeamUser", b =>
                {
                    b.Property<int>("TeamsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TeamsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("TeamUser");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Invite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FriendInvite")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFrom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTo")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InviteFromId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InviteToId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MatchInvite")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TeamInvite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InviteFromId");

                    b.HasIndex("InviteToId");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("OwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GamesWon")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("KnownAs")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TeamUser", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.Team", null)
                        .WithMany()
                        .HasForeignKey("TeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolleyballApp.API.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Invite", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "InviteFrom")
                        .WithMany()
                        .HasForeignKey("InviteFromId");

                    b.HasOne("VolleyballApp.API.Models.User", "InviteTo")
                        .WithMany()
                        .HasForeignKey("InviteToId");

                    b.Navigation("InviteFrom");

                    b.Navigation("InviteTo");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Team", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "Owner")
                        .WithMany("TeamsCreated")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.User", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", null)
                        .WithMany("Friends")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.User", b =>
                {
                    b.Navigation("Friends");

                    b.Navigation("TeamsCreated");
                });
#pragma warning restore 612, 618
        }
    }
}
