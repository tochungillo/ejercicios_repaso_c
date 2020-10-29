namespace TextFileChallange
{
    internal class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string pulse { get; set; }

        public User(string firstName, string lastName, int age, string pulse)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.pulse = pulse;
        }
    }
}