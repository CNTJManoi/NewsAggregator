using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.Models
{
    public abstract class News
    {
        protected News(string content, string footer)
        {
            Content = content;
            Footer = footer;
        }

        public abstract string Title { get; }
        public string Content { get; }
        public string Footer { get; }
    }
}
