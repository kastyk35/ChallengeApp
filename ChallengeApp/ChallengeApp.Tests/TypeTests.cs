namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void StringCompareTest()
        {
            // arrange - przygotowanie
            string string1 = "Kastyk";
            string string2 = "Kastyk";

            // act - wykonanie

            //assert - przewidywany wynik
            Assert.AreEqual(string1, string2);

        }

        [Test]
        public void ValueVariableCompareTest()
        {
            // arrange - przygotowanie
            int num1 = 200;
            int num2 = 200;

            // act - wykonanie

            //assert - przewidywany wynik
            Assert.AreEqual(num1, num2);

        }

        [Test]
        public void ReferenceVarCompareTest()
        {
            // arrange - przygotowanie
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act - wykonanie

            //assert - przewidywany wynik
            Assert.AreNotEqual(user1, user2);

        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
