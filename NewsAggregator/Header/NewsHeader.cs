using NewsAggregator.Logic.Models;

namespace NewsAggregator.Logic.Header;

public abstract class NewsHeader : News //декоратор
{
    protected News news;

    public NewsHeader(News news) : base(news.Content, news.Footer)
    {
        this.news = news;
    }
}