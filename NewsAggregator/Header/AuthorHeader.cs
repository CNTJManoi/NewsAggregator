using NewsAggregator.Logic.Models;

namespace NewsAggregator.Logic.Header;

public class AuthorHeader : NewsHeader //конкретная реализация декоратора
{
    public AuthorHeader(News news, string author) : base(news)
    {
        Author = author;
    }

    public string Author { get; set; }

    public override string Title => $"Автор {Author}: {news.Title}";
}