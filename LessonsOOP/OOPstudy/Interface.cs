namespace LessonsOOP;

public interface IDataProvider
{
    //нельзя объявить неабстрактные методы, нельзя объявить конструктор класса
    //любой класс-наследник реализует интерфейс
    string GetData(); //по умолчанию public 
    //можно реализовать множественное наследование
}

interface IDataProcessor
{
    void ProcessData(IDataProvider dataProvider);
}

class ConsoleDateProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "db base";
    }
}

class FileData : IDataProvider
{
    public string GetData()
    {
        return "file";
    }
}

class IpData : IDataProvider
{
    public string GetData()
    {
        return "ip";
    }
}