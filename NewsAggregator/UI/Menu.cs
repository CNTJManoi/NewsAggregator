using NewsAggregator.Header;
using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAggregator.UI
{
    public class Menu
    {
        NewsDisplayer Display { get; }
        ServiceInformant ServiceInformant { get; }
        NewsRepository NewsRepository { get; }
        int _chooseOption;
        public Menu()
        {
            Display = new NewsDisplayer();
            ServiceInformant = new ServiceInformant();
            NewsRepository = new NewsRepository();
            _chooseOption = -1;
        }
        public void Start()
        {
            Loop();
        }
        private void Loop()
        {
            while(_chooseOption != 0)
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
            if((_chooseOption = CheckInput()) != -1)
            {
                switch (_chooseOption)
                {
                //     Print("1) Вывод новостей политики без шапки автора");
                //Print("2) Вывод новостей спорта без шапки автора");
                //Print("3) Вывод новостей политики с шапкой автора");
                //Print("4) Вывод новостей спорта с шапкой автора");
                    case 1:
                        Display.PrintNews(NewsRepository.GetPoliticsWithoutHeader());
                        break;
                    case 2:
                        Display.PrintNews(NewsRepository.GetSportsNewsWithoutHeader());
                        break;
                    case 3:
                        Display.PrintNews(NewsRepository.GetPoliticsNewsWithHeader());
                        break;
                    case 4:
                        Display.PrintNews(NewsRepository.GetSportsNewsWithHeader());
                        break;
                    case 0:
                        Exit();
                        break;
                }
            }
        }
        private int CheckInput()
        {
            int input = -1;
            try
            {
                input = int.Parse(Console.ReadLine());
            }
            catch (FormatException exception)
            {
                ServiceInformant.PrintErrorInput();
            }
            catch(ArgumentNullException exception)
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
}
