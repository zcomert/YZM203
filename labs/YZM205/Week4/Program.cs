namespace Week4;

public class Program
{
    public static void Main(string[] args)
    {
        Author author = new Author("Arda", "Kucukbas", "a.kucukbas@mail.com");
        Message[] messages = new Message[]
        {
            new Message("Content1"),
            new Message("Content2")
        };
        // author.FullName = "Mehmet Dag";
        BlogPost post1 = new BlogPost(1, "title1", author, messages);
        post1.DisplayPost();
    }
}
