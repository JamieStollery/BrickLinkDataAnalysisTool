namespace Data.Common
{
    public class User
    {
        public string Username { get; set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(Username);
        public void Logout()
        {
            Username = string.Empty;
        }
    }
}
