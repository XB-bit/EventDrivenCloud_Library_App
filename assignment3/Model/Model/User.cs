namespace Model
{
    public class User
    {
        int uID;
        string username;
        string password;
        string email;
        int userLevel;

        public int UID { get => uID; set => uID = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int UserLevel { get => userLevel; set => userLevel = value; }
    }
}
