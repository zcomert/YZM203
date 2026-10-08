namespace Week4
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        { // => FirstName + " " + LastName
            get
            {
                return FirstName + " " + LastName;
            }
        } // Get

        public string Email { get; set; }

        public Author()
        {
            // FullName = FirstName + " " + LastName;
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("I only get firstname-lastname!");
        }

        public Author(string firstName, string lastName, string email)
            : this(firstName, lastName)
        {
            Email = email;
            Console.WriteLine("I only get firstname-lastname-email!");
        }
    }
}
