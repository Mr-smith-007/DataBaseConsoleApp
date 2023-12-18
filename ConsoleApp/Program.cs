
using ClassLibrary;
using System.Data;

public class Program
{
    static void Main(string[] args)
    {
        var connector = new MainConnector();

        var data = new DataTable();

        var result = connector.ConnectAsync();

        if (result.Result)
        {
            Console.WriteLine("Подключено успешно!");

            var db = new DbExecutor(connector);

            var tablename = "NetworkUser";

            Console.WriteLine("Получаем данные таблицы " + tablename);

            data = db.SelectAll(tablename);

            Console.WriteLine("Отключаем БД!");
            connector.DisconnectAsync();

            Console.WriteLine("Количество строк в " + tablename + ": " + data.Rows.Count);
        }
        else
        {
            Console.WriteLine("Ошибка подключения!");
        }


        Console.ReadKey();

    }
}