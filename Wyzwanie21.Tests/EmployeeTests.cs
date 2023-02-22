namespace Wyzwanie21.Tests
{
    public class Tests
    {
        [Test]
        public void WhenAddGrades_ShouldReturnGradeD()
        {
            //arrange
            var employee = new Employee("Sara", "James");
            //act 
            employee.AddGrades(30);
            employee.AddGrades(30);
            employee.AddGrades(40);
            employee.AddGrades(20);
            var stats = employee.GetStatistics();

            //assert
            Assert.AreEqual('D', stats.AvarageLetter);
        }
        [Test]
        public void WhenAddGrades_ShouldRetunMinValue()
        {
            //arrange
            var employee = new Employee("Bill", "Clinton");
            //act 
            employee.AddGrades('A');
            employee.AddGrades("7");
            employee.AddGrades(11);
            employee.AddGrades(100);
            var stats = employee.GetStatistics();
            //assert
            Assert.AreEqual(7, stats.Min);        
        }
        [Test]
        public void WhenAddGradeChar_ShouldReturnAvarage()
        {
            var employee = new Employee("George ", "Clooney");

            employee.AddGrades('a');
            employee.AddGrades('B');
            employee.AddGrades('h');
            var stats = employee.GetStatistics();

            Assert.AreEqual(90, stats.Avarage);

        }
    }
}