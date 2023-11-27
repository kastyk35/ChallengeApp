namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void UserEarnsPositiveAndNegativeScores_ShouldReturnCorrectResult()
        {
            // arrange - przygotowanie
            var emp = new Employee("Janusz");
            emp.AddGrade(15);
            emp.AddGrade(-6);
            emp.AddGrade(9);
            emp.AddGrade(-12);

            // act - wykonanie
            var result = emp.Result;

            //assert - przewidywany wynik
            Assert.AreEqual(6, result);
        }

        [Test]
        public void UserNameCompareTest()
        {
            // arrange - przygotowanie
            var user1 = GetUser("Janek");
            var user2 = GetUser("Jaœko");

            // act - wykonanie
           
            //assert - przewidywany wynik
            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetUser(string name)
        {
            return new Employee(name);
        }

        [Test]
        public void AverageGradeTest()
        {
            var emp = new Employee("John");
            emp.AddGrade(15);
            emp.AddGrade(-6);
            emp.AddGrade(9);
            emp.AddGrade(-12);

            // act - wykonanie
            var result = emp.GetStatistics();

            //assert - przewidywany wynik
            Assert.AreEqual(1.5, result.Average);
        }
    }
}
