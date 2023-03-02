using NewsAggregator.Generator;
using NewsAggregator.Generator.Types;
using NewsAggregator.UI.Operations;

namespace NewsAggregator.UI;

public class Menu
{
    private int _chooseOption;

    public Menu()
    {
        Display = new NewsDisplayer();
        ServiceInformant = new ServiceInformant();
        _chooseOption = -1;
    }

    private NewsDisplayer Display { get; }
    private ServiceInformant ServiceInformant { get; }
    private NewsGenerator NewsRepository { get; set; }

    public void Start()
    {
        Loop();
    }

    private void Loop()
    {
        while (_chooseOption != 0)
        {
            PrintMainMenu();
            ChooseOption();
            ExpectPressed();
            ClearScreen();
        }
    }

    private void PrintMainMenu()
    {
        ServiceInformant.TitleMenu();
        ServiceInformant.PrintOptions();
    }

    private void ClearScreen()
    {
        Console.Clear();
    }

    private void ExpectPressed()
    {
        Console.ReadKey();
    }

    private void ChooseOption()
    {
        if ((_chooseOption = CheckInput()) != -1)
        {
            switch (_chooseOption)
            {
                case 1:
                    NewsRepository = new PoliticsNewsGenerator();
                    Display.PrintNews(NewsRepository.GenerateNewsWithoutHeader());
                    break;
                case 2:
                    NewsRepository = new SportsNewsGenerator();
                    Display.PrintNews(NewsRepository.GenerateNewsWithoutHeader());
                    break;
                case 3:
                    NewsRepository = new PoliticsNewsGenerator();
                    Display.PrintNews(NewsRepository.GenerateNewsWithHeader());
                    break;
                case 4:
                    NewsRepository = new SportsNewsGenerator();
                    Display.PrintNews(NewsRepository.GenerateNewsWithHeader());
                    break;
                case 0:
                    Exit();
                    break;
                default:
                    ServiceInformant.PrintOutOfRangeError();
                    break;
            }

            return;
        }

        ServiceInformant.PrintOutOfRangeError();
    }

    private int CheckInput()
    {
        var input = -1;
        try
        {
            input = int.Parse(Console.ReadLine());
        }
        catch (FormatException exception)
        {
            ServiceInformant.PrintErrorInput();
        }
        catch (ArgumentNullException exception)
        {
            ServiceInformant.PrintErrorNullInput();
        }
        catch (Exception exception)
        {
            ServiceInformant.PrintUnknownError(exception);
        }

        return input;
    }

    private void Exit()
    {
        Environment.Exit(0);
    }
}