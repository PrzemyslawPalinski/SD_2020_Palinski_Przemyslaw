namespace VolleyballApp.API.Dtos
{
    public class InviteToReturnDto
    {
        public int Id { get; set; }
        public UserForListDto InviteFrom { get; set; }
        public UserForListDto InviteTo { get; set; }
        public TeamsForListDto TeamInviting { get; set; }
        public TeamsForListDto TeamInvited { get; set; }
        public MatchForListDto MatchInvitedTo { get; set; }
        public bool FriendInvite { get; set; }
        public bool TeamInvite { get; set; }
        public bool MatchInvite { get; set; }
        public bool RefereeInvite { get; set; }
    }
}