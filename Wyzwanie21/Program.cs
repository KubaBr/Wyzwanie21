using Wyzwanie21;

Console.WriteLine("Witamy w naszej aplikacji do oceny pracownikow!");
Console.WriteLine("===============================================");
Console.WriteLine();

var employee = new Employee("Sebastian", "Sebikowski");
//try
//{
//    Employee empl = null;
//    var name = empl.Name;
//}
//catch(Exception error)
//{
//    Console.WriteLine(error.Message);
//}
//finally
//{
//    Console.WriteLine("Finnaly here");
//}


while (true)
{
    Console.WriteLine("Wprowadz ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrades(input);
    }
    catch (Exception err)
    {
        Console.WriteLine($"Pojawili sie wyjatek {err.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Srednia: {statistics.Avarage}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");