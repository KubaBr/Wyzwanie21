using static Wyzwanie21.EmployeeBase;

namespace Wyzwanie21
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        public void AddGrades(float grade);
        public void AddGrades(char grade);
        public void AddGrades(string grade);
        public void AddGrades(int grade);
        public void AddGrades(double grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}
