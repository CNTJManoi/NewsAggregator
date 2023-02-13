using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.Header
{
    public abstract class NewsHeader : News //декоратор
    {
        protected News news;
        public NewsHeader(News news) : base(news.Content, news.Footer)
        {
            this.news = news;
        }
    }
}
