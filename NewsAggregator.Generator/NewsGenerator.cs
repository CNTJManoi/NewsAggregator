using NewsAggregator.Logic.Models;

namespace NewsAggregator.Generator;

public abstract class NewsGenerator
{
    //фабричный метод
    public abstract News GenerateNewsWithoutHeader();
    public abstract News GenerateNewsWithHeader();
}