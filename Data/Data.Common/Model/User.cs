namespace Data.Common.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConsumerKey { get; set; }
        public string ConsumerSecret { get; set; }
        public string TokenValue { get; set; }
        public string TokenSecret { get; set; }

        public bool IsLoggedIn => !string.IsNullOrEmpty(Username);

        public void Invalidate()
        {
            Username = string.Empty;
            Password = string.Empty;
            ConsumerKey = string.Empty;
            ConsumerSecret = string.Empty;
            TokenValue = string.Empty;
            TokenSecret = string.Empty;
        }
    }
}
