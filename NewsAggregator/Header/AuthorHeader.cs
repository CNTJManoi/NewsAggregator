using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.Header
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
