using Wyzwanie21;

var emplo = new Employee("Edyta", "Edkowska");

double zmienna = double.MaxValue;

emplo.AddGrades(zmienna);
emplo.AddGrades("Kuba");
emplo.AddGrades("4");
emplo.AddGrades(4);
emplo.AddGrades(77);
emplo.AddGrades(707);
emplo.AddGrades(-5);

var statistics = emplo.GetStatistics();
var statistics1 = emplo.GetStatisticsWithFor();
var statistics2 = emplo.GetStatisticsWithDoWhile();
var statistics3 = emplo.GetStatisticsWithWhile();
Console.WriteLine();

Console.Write($"Avarege: {statistics.Avarage:N2} ");
Console.Write($"Min: {statistics.Min} ");
Console.Write($"Max: {statistics.Max} ");
Console.WriteLine();

Console.Write($"Avarege For: {statistics1.Avarage:N2} ");
Console.Write($"Min For: {statistics1.Min} ");
Console.Write($"Max For: {statistics1.Max} ");
Console.WriteLine();

Console.Write($"Avarege doWhile: {statistics2.Avarage:N2} ");
Console.Write($"Min doWhile: {statistics2.Min} ");
Console.Write($"Max doWhile: {statistics2.Max} ");
Console.WriteLine();

Console.Write($"Avarege While: {statistics3.Avarage:N2} ");
Console.Write($"Min While: {statistics3.Min} ");
Console.Write($"Max While: {statistics3.Max} ");
Console.WriteLine();