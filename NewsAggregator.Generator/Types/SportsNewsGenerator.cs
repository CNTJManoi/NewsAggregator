using NewsAggregator.Logic.Header;
using NewsAggregator.Logic.Models;

namespace NewsAggregator.Generator.Types;

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