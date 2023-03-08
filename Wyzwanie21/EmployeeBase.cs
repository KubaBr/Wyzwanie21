namespace Wyzwanie21
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void AddGrades(float grade);
        public abstract void AddGrades(char grade);
        public abstract void AddGrades(string grade);
        public abstract void AddGrades(int grade);
        public abstract void AddGrades(double grade);
        public abstract Statistics GetStatistics();

    }

}
