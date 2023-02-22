using Wyzwanie21;

Console.WriteLine("Witamy w naszej aplikacji do oceny pracownikow!");
Console.WriteLine("===============================================");
Console.WriteLine();


var employee = new Employee("Sebastian", "Sebikowski");


while (true)
{
    Console.WriteLine("Wprowadz ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrades(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Srednia: {statistics.Avarage}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
