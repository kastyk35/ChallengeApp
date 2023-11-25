using ChallengeApp;

// Lista pracowników

Employee user1 = new Employee("Jan", "Basiorek", "33");
Employee user2 = new Employee("Wanda", "Zimniutka", "49");
Employee user3 = new Employee("Alojzy", "Kościsty", "53");

// Lista ocen pracowników

user1.AddScore(5);
user1.AddScore(3);
user1.AddScore(3);
user1.AddScore(8);
user1.AddScore(9);

user2.AddScore(4);
user2.AddScore(5);
user2.AddScore(3);
user2.AddScore(8);
user2.AddScore(9);

user3.AddScore(9);
user3.AddScore(2);
user3.AddScore(3);
user3.AddScore(0);
user3.AddScore(7);

List<Employee> employees = new List<Employee>() { user1, user2, user3 };

int maxResult = -1;
Employee empWithMaxResult = null;

foreach (var user in employees)
{
    if (user.Result > maxResult)
    {
        empWithMaxResult = user;
        maxResult = user.Result;
    }
}

Console.WriteLine("Pracownikiem z najwyższą oceną jest: " + empWithMaxResult.Name + " " + empWithMaxResult.Surname + ", lat: " + empWithMaxResult.Age + " z wynikiem: " + empWithMaxResult.Result + ".");
