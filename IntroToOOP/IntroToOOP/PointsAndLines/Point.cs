namespace PointsAndLines
{
    class User
    {
        public readonly int HEIGHT;
        public readonly int ID;

        public static int currentId;

        public Race race;

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

        public User(string username, Race race)
        {
            currentId++;
            this.ID = currentId;
            this.username = username;
            this.race = race;

            if (this.race == Race.Marsian)
            {
                HEIGHT = 100;
            }
            else if (this.race == Race.Earthling)
            {
                HEIGHT = 180;
            }
        }

        public User() {
            currentId++;
            this.ID = currentId;

            if (this.race == Race.Marsian)
            {
                HEIGHT = 100;
            }
            else if (this.race == Race.Earthling)
            {
                HEIGHT = 180;
            }

        }
    }

}
