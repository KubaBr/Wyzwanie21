using System.Diagnostics;
namespace Wyzwanie21
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public Employee(string cName, string cSurname)
        {
            this.Name = cName;
            this.Surname = cSurname;
        }
        public void AddGrades(float grade)
        {
            int valueInInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Niepoprawna wartosc oceny");
            }
        }
        public void AddGrades(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Podaj poprawna litere");
            }
        }
        public void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                throw new Exception("String nie jest liczbą zmiennoprzecinkowa");
            }
        }
        public void AddGrades(int grade)
        {
            this.AddGrades((float)grade);
        }
        public void AddGrades(double grade)
        {
            if (grade <= float.MaxValue)
            {
                this.AddGrades((float)grade);
            }
            else
            {
                throw new Exception("Wprowadzony double wykracza poza zakres float");
            }
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarage += grade;
            }
            statistics.Avarage /= this.grades.Count;

            switch (statistics.Avarage)
            {
                case var avarage when avarage >= 80:
                    statistics.AvarageLetter = 'A';
                    break;
                case var avarage when avarage >= 60:
                    statistics.AvarageLetter = 'B';
                    break;
                case var avarage when avarage >= 40:
                    statistics.AvarageLetter = 'C';
                    break;
                case var avarage when avarage >= 20:
                    statistics.AvarageLetter = 'D';
                    break;
                default:
                    statistics.AvarageLetter = 'E';
                    break;

            }

            return statistics;
        }

    }
}