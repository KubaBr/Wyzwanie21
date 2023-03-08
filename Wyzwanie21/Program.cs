using Wyzwanie21;

Console.WriteLine("Witamy w naszej aplikacji do oceny pracownikow!");
Console.WriteLine("===============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Sebastian", "Sebikowski");
var employee2 = new EmployeeInMemory("Grzegorz", "Grzesinski");

employee2.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
employee2.AddGrades(0.9f);

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