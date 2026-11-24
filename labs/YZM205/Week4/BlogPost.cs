namespace Week4;

public class BlogPost
{
    public int BlogPostId { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
    public Message[] Messages { get; set; }

    public BlogPost(int blogPostId, string title, Author author, Message[] messages)
    {
        BlogPostId = blogPostId;
        Title = title;
        Author = author;
        Messages = messages;
    }

    public void DisplayPost()
    {
        Console.WriteLine($"Author: {Author.FullName}\n" +
            $"Title: {Title}");

        for (int i = 0; i < Messages.Length; i++)
            Console.WriteLine($"{Messages[i].Content}");
    }
}
