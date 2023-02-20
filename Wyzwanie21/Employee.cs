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
                Console.WriteLine($"Podana ocena jest nieprawidlowa! {grade}");
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
                Console.WriteLine("String nie jest liczbą zmiennoprzecinkowa");
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
                Console.WriteLine("Wprowadzony double wykracza poza zakres float");
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

            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Avarage += grades[i];
            }
            statistics.Avarage /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            int i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Avarage += grades[i];
                i++;
            } while (i < this.grades.Count);
            statistics.Avarage /= this.grades.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            int i = 0;
            while (i < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Avarage += grades[i];
                i++;
            }

            statistics.Avarage /= this.grades.Count;

            return statistics;
        }

    }
}