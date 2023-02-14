namespace NewsAggregator.Logic.Models;

public class LocalNews : News
{
    public LocalNews(string title, string content, string footer) : base(content, footer)
    {
        Title = title;
    }

    public override string Title { get; }
}