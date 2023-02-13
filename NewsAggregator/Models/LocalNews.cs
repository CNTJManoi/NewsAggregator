using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.Models
{
    public class LocalNews : News
    {
        public LocalNews(string title, string content, string footer) : base(content, footer) 
        { 
            Title = title;
        }

        public override string Title { get; }
    }

}
