namespace Wyzwanie21
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public Person(string cName, string cSurname)
        {
            this.Name = cName;
            this.Surname = cSurname;
            this.Gender = "unknown";
        }
        public Person(string cName, string cSurname, string cGender)
        {
            this.Name = cName;
            this.Surname = cSurname;
            this.Gender = cGender;
        }
    }
}
