namespace PointsAndLines
{
    class User
    {
        private string username;
        private int password;

        public string Username {
            get
            {
                return username;
            }
            set
            {
                if (value.Length > 4 && value.Length < 10)
                {
                    username = value;
                }
                else
                {
                    System.Console.WriteLine("Oops, username must have 4 to 10 characters.");
                }

            }
        }

        public int Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public User(string username, int password)
        {
            this.username = username;
            this.password = password;
        }

        public User() {
        }
    }

}
