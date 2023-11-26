namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserEarnsScores_ThenShouldReturnCorrectResult()
        {
            // arrange - przygotowanie
            var user = new User("Kastyk");
            user.AddScore(15);
            user.AddScore(-6);
            user.AddScore(9);
            user.AddScore(-12);

            // act - wykonanie
            var result = user.Result;

            //assert - przewidywany wynik
            Assert.AreEqual(6, result);
        }
    }
}
