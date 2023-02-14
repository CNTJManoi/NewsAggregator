namespace NewsAggregator.UI.Operations;

internal class ServiceInformant
{
    public void TitleMenu()
    {
        ColorToRed();
        Print("Добро пожаловать в агрегатор новостей!");
        ColorToWhite();
        Print("Наше приложение позволяет получать всю нужную информацию о происходящем во всем мире!");
        Print("Выберите необходимую опцию меню: ");
    }

    public void PrintOptions()
    {
        Print("1) Вывод новостей политики без шапки автора");
        Print("2) Вывод новостей спорта без шапки автора");
        Print("3) Вывод новостей политики с шапкой автора");
        Print("4) Вывод новостей спорта с шапкой автора");
        Print("0) Выход из приложения");
    }

    public void PrintErrorInput()
    {
        Print("Введен номер некоректной опции!");
        Print("Попробуйте еще раз...");
    }

    public void PrintOutOfRangeError()
    {
        Print("Вы выбрали несуществующий пункт меню!");
        Print("Попробуйте еще раз...");
    }

    public void PrintErrorNullInput()
    {
        Print("Вы не ввели необходимую опцию!");
        Print("Попробуйте еще раз...");
    }

    public void PrintUnknownError(Exception exception)
    {
        Print("Произошла неизвестная ошибка: " + exception.Message);
        Print("Сообщите о данной ошибке разработчику приложения");
    }

    private void Print(string str)
    {
        Console.WriteLine(str);
    }

    private void ColorToRed()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    private void ColorToWhite()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}