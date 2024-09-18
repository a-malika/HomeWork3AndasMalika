//1 задание
public class Log
{
    public void LogMessage(string message, string typeOfMessage)
    {
        Console.WriteLine(typeOfMessage.ToUpper() + ": " + message);
    }
}

//2 задание
public class InfoConnection
{
    public static string connectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}
public class DatabaseService
{
    public void Connect()
    {
        // Логика подключения к базе данных
        // При надобности используем InfoConnection.connectionString
    }
}
public class LoggingService
{
    public void Log()
    {
        // Логика записи лога в базу данных
        // При надобности используем InfoConnection.connectionString
    }
}

public class Processing
{
    //3 задание
    public void ProcessNumbers(int[] numbers)
    {
        foreach (var number in numbers)
            if (number > 0) Console.WriteLine(number);
    }

    //4 задание
    public void PrintPositiveNumbers(int[] numbers)
    {
        foreach (int number in numbers)
            if (number > 0) Console.WriteLine(number);
    }

    //5 задание
    public int Divide(int a, int b)
    {
        if (b == 0) return 0;
        return a / b;
    }
}



//6 задание

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    // Все методы что были никак не связаны именно с классом User
    // Удалим их, это лишний функционал
    // Если он и понадобится, то лучше создать для него отдельные классы
}

//7 задание
public class FileReader
{
    public string ReadFile(string filePath)
    {
        // Логика чтения файла
        return "file content";
    }
}

//8 задание
public class ReportGenerator
{
    public void GeneratePdfReport()
    {
        // Генерация Pdf отчета
    }
}
