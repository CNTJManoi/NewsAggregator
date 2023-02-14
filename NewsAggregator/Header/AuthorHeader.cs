using NewsAggregator.Logic.Models;

namespace NewsAggregator.Logic.Header
{
    public class AuthorHeader : NewsHeader //конкретная реализация декоратора
    {
        public string Author { get; set; }
        public AuthorHeader(News news, string author) : base(news)
        {
            Author = author;
        }

        public override string Title { 
            get { return $"Автор {Author}: {news.Title}"; } 
        }
    }
}
