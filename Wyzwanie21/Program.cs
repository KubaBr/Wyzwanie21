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
