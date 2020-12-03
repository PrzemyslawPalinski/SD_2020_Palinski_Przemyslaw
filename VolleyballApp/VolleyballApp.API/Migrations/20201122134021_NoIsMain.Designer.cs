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
    [Migration("20201122134021_NoIsMain")]
    partial class NoIsMain
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

            modelBuilder.Entity("VolleyballApp.API.Models.Friendlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FirstUserId");

                    b.HasIndex("SecondUserId");

                    b.ToTable("Friendlist");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Invite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("FriendInvite")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InviteFromId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InviteToId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MatchInvite")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TeamInvite")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeamInvitedId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeamInvitingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InviteFromId");

                    b.HasIndex("InviteToId");

                    b.HasIndex("TeamInvitedId");

                    b.HasIndex("TeamInvitingId");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondTeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FirstTeamId");

                    b.HasIndex("ScoreId")
                        .IsUnique();

                    b.HasIndex("SecondTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FirstTeamSets")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FiveFirstTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FiveSecondTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FourFirstTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FourSecondTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OneFirstTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OneSecondTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SecondTeamSets")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThreeFirstTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThreeSecondTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TwoFirstTeam")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TwoSecondTeam")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Scores");
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

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

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

            modelBuilder.Entity("VolleyballApp.API.Models.Friendlist", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "FirstUser")
                        .WithMany()
                        .HasForeignKey("FirstUserId");

                    b.HasOne("VolleyballApp.API.Models.User", "SecondUser")
                        .WithMany()
                        .HasForeignKey("SecondUserId");

                    b.Navigation("FirstUser");

                    b.Navigation("SecondUser");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Invite", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "InviteFrom")
                        .WithMany()
                        .HasForeignKey("InviteFromId");

                    b.HasOne("VolleyballApp.API.Models.User", "InviteTo")
                        .WithMany()
                        .HasForeignKey("InviteToId");

                    b.HasOne("VolleyballApp.API.Models.Team", "TeamInvited")
                        .WithMany()
                        .HasForeignKey("TeamInvitedId");

                    b.HasOne("VolleyballApp.API.Models.Team", "TeamInviting")
                        .WithMany()
                        .HasForeignKey("TeamInvitingId");

                    b.Navigation("InviteFrom");

                    b.Navigation("InviteTo");

                    b.Navigation("TeamInvited");

                    b.Navigation("TeamInviting");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Match", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.Team", "FirstTeam")
                        .WithMany()
                        .HasForeignKey("FirstTeamId");

                    b.HasOne("VolleyballApp.API.Models.Score", "Score")
                        .WithOne("Match")
                        .HasForeignKey("VolleyballApp.API.Models.Match", "ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolleyballApp.API.Models.Team", "SecondTeam")
                        .WithMany()
                        .HasForeignKey("SecondTeamId");

                    b.Navigation("FirstTeam");

                    b.Navigation("Score");

                    b.Navigation("SecondTeam");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Photo", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.HasOne("VolleyballApp.API.Models.User", "User")
                        .WithOne("Photo")
                        .HasForeignKey("VolleyballApp.API.Models.Photo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("User");
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

            modelBuilder.Entity("VolleyballApp.API.Models.Score", b =>
                {
                    b.Navigation("Match");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.User", b =>
                {
                    b.Navigation("Photo");

                    b.Navigation("TeamsCreated");
                });
#pragma warning restore 612, 618
        }
    }
}
