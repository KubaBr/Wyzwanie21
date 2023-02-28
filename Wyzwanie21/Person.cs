namespace Wyzwanie21
{
    public abstract class Person
    {
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public Person(string cSurname)
        {

            this.Surname = cSurname;
            this.Gender = "unknown";
        }
        public Person(string cSurname, string cGender)
        {
            this.Surname = cSurname;
            this.Gender = cGender;
        }
    }
}
