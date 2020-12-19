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
    [Migration("20201219113154_LeagueClosingTime")]
    partial class LeagueClosingTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

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

                    b.Property<int?>("MatchInvitedToId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("RefereeInvite")
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

                    b.HasIndex("MatchInvitedToId");

                    b.HasIndex("TeamInvitedId");

                    b.HasIndex("TeamInvitingId");

                    b.ToTable("Invites");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClosedSignUp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamLimit")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adress")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeOfMatch")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FirstTeamId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRefereeInvited")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LeagueId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RefereeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SecondTeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FirstTeamId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("LocationId");

                    b.HasIndex("RefereeId");

                    b.HasIndex("ScoreId")
                        .IsUnique();

                    b.HasIndex("SecondTeamId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("MessageSent")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RecipientDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipientId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SenderDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RecipientId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");
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

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId")
                        .IsUnique();

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

                    b.Property<int>("RankingPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .IsUnique();

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.TeamLeague", b =>
                {
                    b.Property<int>("LeagueId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeagueGames")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeagueLosses")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeagueScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeagueWins")
                        .HasColumnType("INTEGER");

                    b.HasKey("LeagueId", "TeamId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamLeague");
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

                    b.Property<int>("RankingPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TeamId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserType")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");
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

                    b.HasOne("VolleyballApp.API.Models.Match", "MatchInvitedTo")
                        .WithMany()
                        .HasForeignKey("MatchInvitedToId");

                    b.HasOne("VolleyballApp.API.Models.Team", "TeamInvited")
                        .WithMany()
                        .HasForeignKey("TeamInvitedId");

                    b.HasOne("VolleyballApp.API.Models.Team", "TeamInviting")
                        .WithMany()
                        .HasForeignKey("TeamInvitingId");

                    b.Navigation("InviteFrom");

                    b.Navigation("InviteTo");

                    b.Navigation("MatchInvitedTo");

                    b.Navigation("TeamInvited");

                    b.Navigation("TeamInviting");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.League", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Match", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.Team", "FirstTeam")
                        .WithMany()
                        .HasForeignKey("FirstTeamId");

                    b.HasOne("VolleyballApp.API.Models.League", null)
                        .WithMany("Matches")
                        .HasForeignKey("LeagueId");

                    b.HasOne("VolleyballApp.API.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("VolleyballApp.API.Models.User", "Referee")
                        .WithMany("RefereeMatches")
                        .HasForeignKey("RefereeId");

                    b.HasOne("VolleyballApp.API.Models.Score", "Score")
                        .WithOne("Match")
                        .HasForeignKey("VolleyballApp.API.Models.Match", "ScoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolleyballApp.API.Models.Team", "SecondTeam")
                        .WithMany()
                        .HasForeignKey("SecondTeamId");

                    b.Navigation("FirstTeam");

                    b.Navigation("Location");

                    b.Navigation("Referee");

                    b.Navigation("Score");

                    b.Navigation("SecondTeam");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Message", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "Recipient")
                        .WithMany("MessagesReceived")
                        .HasForeignKey("RecipientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("VolleyballApp.API.Models.User", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Recipient");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Photo", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.Team", "Team")
                        .WithOne("Photo")
                        .HasForeignKey("VolleyballApp.API.Models.Photo", "TeamId");

                    b.HasOne("VolleyballApp.API.Models.User", "User")
                        .WithOne("Photo")
                        .HasForeignKey("VolleyballApp.API.Models.Photo", "UserId");

                    b.Navigation("Team");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Team", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.User", "Owner")
                        .WithOne("OwnedTeam")
                        .HasForeignKey("VolleyballApp.API.Models.Team", "OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.TeamLeague", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.League", "League")
                        .WithMany("TeamLeague")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VolleyballApp.API.Models.Team", "Team")
                        .WithMany("TeamLeague")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.User", b =>
                {
                    b.HasOne("VolleyballApp.API.Models.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.League", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("TeamLeague");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Score", b =>
                {
                    b.Navigation("Match");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.Team", b =>
                {
                    b.Navigation("Photo");

                    b.Navigation("TeamLeague");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VolleyballApp.API.Models.User", b =>
                {
                    b.Navigation("MessagesReceived");

                    b.Navigation("MessagesSent");

                    b.Navigation("OwnedTeam");

                    b.Navigation("Photo");

                    b.Navigation("RefereeMatches");
                });
#pragma warning restore 612, 618
        }
    }
}
