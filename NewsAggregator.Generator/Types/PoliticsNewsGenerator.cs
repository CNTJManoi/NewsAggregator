using NewsAggregator.Logic.Header;
using NewsAggregator.Logic.Models;

namespace NewsAggregator.Generator.Types;

public class PoliticsNewsGenerator : NewsGenerator
{
    public override News GenerateNewsWithHeader()
    {
        var news = GenerateNewsWithoutHeader();
        return new AuthorHeader(
            news,
            "Юлия Новикова / Фото: © NurPhoto / Contributor / NurPhoto / Gettyimages.ru"
        );
    }

    public override News GenerateNewsWithoutHeader()
    {
        return new LocalNews(
            "Сын Никаса Сафронова застрял в унитазе на борту самолета и попал на видео",
            "Я не умру в туалете",
            "У нас есть свежие новости для вас"
        );
    }
}