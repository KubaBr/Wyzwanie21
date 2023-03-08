using System.Diagnostics;

namespace Wyzwanie21
{
    public class EmployeeInFile : EmployeeBase
    {
        private string fileName = "grades.txt";
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;


        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrades(float grade)
        {
            int valueInInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Niepoprawna wartosc oceny");
            }
        }

        public override void AddGrades(char grade)
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

        public override void AddGrades(string grade)
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

        public override void AddGrades(int grade)
        {
            this.AddGrades((float)grade);
        }

        public override void AddGrades(double grade)
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

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if (File.Exists(fileName))
            {

                using (var reader = File.OpenText(fileName))
                {

                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }

            return result;
        }
    }

}
