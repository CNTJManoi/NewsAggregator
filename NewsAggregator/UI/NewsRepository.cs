using NewsAggregator.Generator.Types;
using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.UI
{
    internal class NewsRepository
    {
        public NewsRepository()
        {
            PoliticsNews = new PoliticsNewsGenerator();
            SportsNews = new SportsNewsGenerator();
        }

        PoliticsNewsGenerator PoliticsNews { get; }
        SportsNewsGenerator SportsNews { get; }
        public News GetPoliticsWithoutHeader()
        {
            return PoliticsNews.GenerateNewsWithoutHeader();
        }
        public News GetSportsNewsWithoutHeader()
        {
            return SportsNews.GenerateNewsWithoutHeader();
        }
        public News GetPoliticsNewsWithHeader()
        {
            return PoliticsNews.GenerateNewsWithHeader();
        }
        public News GetSportsNewsWithHeader()
        {
            return SportsNews.GenerateNewsWithHeader();
        }
    }
}
