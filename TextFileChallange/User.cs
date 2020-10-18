namespace TextFileChallange
{
    internal class User
    {
        private string firstName, lastName;
        private int age;
        private string alive;

        public User(string firstName, string lastName, int age, bool alive)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            if (alive)
                this.alive = "Alive";
            else
                this.alive = "Dead";
        }

        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public int getAge() { return age; }
        public string getAlive() { return alive; }

    }
}