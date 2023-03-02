namespace NewsAggregator.Logic.Models;

public class News
{
    public News(string title, string content, string footer)
    {
        Title = title;
        Content = content;
        Footer = footer;
    }

    public virtual string Title { get; }
    public string Content { get; }
    public string Footer { get; }
}