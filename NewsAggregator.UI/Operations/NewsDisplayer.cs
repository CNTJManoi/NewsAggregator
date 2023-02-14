using NewsAggregator.Logic.Models;

namespace NewsAggregator.UI.Operations;

//класс вывода на экран различных новостей
internal class NewsDisplayer
{
    public void PrintNews(News news)
    {
        Console.WriteLine(news.Title);
        Console.WriteLine(news.Content);
        Console.WriteLine(news.Footer);
    }
}