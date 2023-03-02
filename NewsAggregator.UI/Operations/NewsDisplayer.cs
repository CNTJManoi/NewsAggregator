using NewsAggregator.Logic.Models;

namespace NewsAggregator.UI.Operations;

//класс вывода на экран различных новостей
internal class NewsDisplayer
{
    public void PrintNews(News news)
    {
        Print(news.Title);
        Print(news.Content);
        Print(news.Footer);
    }
    private void Print(string str)
    {
        Console.WriteLine(str);
    }
}