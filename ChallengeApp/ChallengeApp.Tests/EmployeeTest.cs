namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeEarns5GoodAndBadScores_ThenShouldReturnCorrectResult()
        {
            // arrange - przygotowanie
            var employee = new Employee("Jan", "Basiorek", "33");
            employee.AddScore(5);
            employee.AddScore(-6);
            employee.AddScore(1);
            employee.AddScore(-16);
            employee.AddScore(31);

            // act - wykonanie
            var result = employee.Result;

            //assert - przewidywany wynik
            Assert.AreEqual(15, result);
        }
    }
}
