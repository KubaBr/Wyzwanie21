using System;

namespace Wyzwanie21
{
    public class Supervisor : IEmployee
    {
        public string Name => throw new NotImplementedException();
        private List<float> grades = new List<float>();
        public string SuperName { get; private set; }
        public string SuperSurname { get; private set; }
        public Supervisor(string cName, string cSurname)

        {
            this.SuperName = cName;
            this.SuperSurname = cSurname;
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
            throw new NotImplementedException();
        }

        public void AddGrades(string grade)
        {
            float tmp = 0;
            foreach (char x in grade)
            {
                if (x == '+')
                {
                    tmp += 5;
                }
                else if (x == '-')
                {
                    tmp -= 5;
                }
                switch (x)
                {
                    case '6':
                        tmp += 100;
                        break;
                    case '5':
                        tmp += 80;
                        break;
                    case '4':
                        tmp += 60;
                        break;
                    case '3':
                        tmp += 40;
                        break;
                    case '2':
                        tmp += 20;
                        break;
                    default:
                        tmp += 0;
                        break;
                }
            }
            this.AddGrades(tmp);

        }

        public void AddGrades(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrades(double grade)
        {
            throw new NotImplementedException();
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
