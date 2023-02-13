using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.UI
{
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
}
