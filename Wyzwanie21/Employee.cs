namespace Wyzwanie21
{
    public class Employee : Person
    {

        public string Name { get; private set; }
        public Employee(string cName, string cSurname)
    : base(cName, cSurname)
        {

        }
        public Employee(string cName, string cSurname, string cGender)
            : base(cSurname, cGender)
        {

        }
        public void AddGrades(float grade)
        {
            
        }
        public void AddGrades(char grade)
        {
            
        }
        public void AddGrades(string grade)
        {
            
        }
        public void AddGrades(int grade)
        {
            
        }
        public void AddGrades(double grade)
        {
            
        }


    }
}