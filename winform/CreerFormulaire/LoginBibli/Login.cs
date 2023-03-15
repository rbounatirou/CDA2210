namespace LoginBibli
{
    public class Login
    {
        private string username;
        private string password;

        public string Username { get => username; }
        private Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Login Clone()
        {
            return new Login(this.username, this.password);
        }

        public static Login? TryConnect(string _userName, string _password)
        {
            return (_userName == _password ? new Login(_userName, _password) : null);
        }
    }
}