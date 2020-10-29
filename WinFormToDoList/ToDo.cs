namespace WinFormToDoList
{
    internal class ToDo
    {
        public int preference { get; set; }
        public string description { get; set; }

        public ToDo(int preference, string description)
        {
            this.preference = preference;
            this.description = description;
        }
        public string toString()
        {
            return preference + ": " + description;
        }
    }
}