using System;
using System.Collections.Generic;

namespace VolleyballApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public string Mail { get; set; }
        public bool IsMailActivated { get; set; }
        public string Description { get; set; }
        public string Positions { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int RankingPoints { get; set; }
        public Photo Photo { get; set; }
        public UserTeam UserTeam { get; set;}
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
        public ICollection<Match> RefereeMatches { get; set; }
    }
}