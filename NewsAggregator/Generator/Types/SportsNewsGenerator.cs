using NewsAggregator.Header;
using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.Generator.Types
{
    public class SportsNewsGenerator : NewsGenerator
    {
        public override News GenerateNewsWithHeader()
        {
            var news = GenerateNewsWithoutHeader();
            return new AuthorHeader(
                news,
                "РИА Новости / Алексей Майшев"
            );
        }

        public override News GenerateNewsWithoutHeader()
        {
            return new LocalNews(
                "В правительстве появится комиссия по развитию беспилотных авиасистем",
                "Председатель правительства РФ Михаил Мишустин образовал правительственную комиссию по развитию беспилотных авиационных систем, соответствующее постановление опубликовано на официальном интернет-портале правовой информации.",
                "Желаем вам удачного дня!"
            );
        }

    }
}
