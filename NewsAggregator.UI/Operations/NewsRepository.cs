using NewsAggregator.Generator.Types;
using NewsAggregator.Logic.Models;

namespace NewsAggregator.UI.Operations;

internal class NewsRepository
{
    public NewsRepository()
    {
        PoliticsNews = new PoliticsNewsGenerator();
        SportsNews = new SportsNewsGenerator();
    }

    private PoliticsNewsGenerator PoliticsNews { get; }
    private SportsNewsGenerator SportsNews { get; }

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