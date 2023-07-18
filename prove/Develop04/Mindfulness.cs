public abstract class MindfulnessActivity
    {
        private string _name;
        private string _description;
        private int _duration;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public MindfulnessActivity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void Start()
        {
            Console.WriteLine($"Welcome to the {Name}.");
            Console.WriteLine(Description);
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Get ready...");
            ShowAnimation(3);
        }

        public abstract void Perform();

        public virtual void End()
        {
            Console.WriteLine("Well done!!");
            ShowAnimation(3);
            Console.WriteLine($"You have completed the {Name} for {Duration} seconds.");
        }

        protected void ShowAnimation(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }