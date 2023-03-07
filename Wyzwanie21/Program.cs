using Wyzwanie21;

Console.WriteLine("Witamy w naszej aplikacji do oceny pracownikow!");
Console.WriteLine("===============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Sebastian", "Sebikowski");

employee.AddGrades(0.7f);
employee.AddGrades(0.2f);
employee.AddGrades(0.4f);
employee.AddGrades(0.4f);

var result = employee.GetStatistics();
Console.WriteLine($"Srednia: {result.Avarage}");
Console.WriteLine($"Min: {result.Min}");
Console.WriteLine($"Max: {result.Max}");

//while (true)
//{
//    Console.WriteLine("Wprowadz ocene pracownika: ");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {
//        employee.AddGrades(input);
//    }
//    catch (Exception err)
//    {
//        Console.WriteLine($"Pojawili sie wyjatek {err.Message}");
//    }
//}

//var statistics = employee.GetStatistics();
//Console.WriteLine($"Srednia: {statistics.Avarage}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");