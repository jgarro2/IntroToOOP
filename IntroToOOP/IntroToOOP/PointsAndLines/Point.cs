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
        }

        public int Password
        {
            set
            {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    System.Console.WriteLine("Oops, the password must be a number between 4 and 10.");
                }
            }
        }

        public User(string username)
        {
            this.username = username;            
        }

        public User() {
        }
    }

}
