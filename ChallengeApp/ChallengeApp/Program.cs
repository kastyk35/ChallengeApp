using ChallengeApp;

var employee1 = new Employee("Janusz", "Kastyk");
Console.WriteLine("Dane dla {0} {1}: ", employee1.Name, employee1.Surname);
employee1.AddGrade(101);
employee1.AddGrade("Supcio!");
employee1.AddGrade(4);
employee1.AddGrade(4);
employee1.AddGrade(2);
var statistics1 = employee1.GetStatistics();
Console.WriteLine($"Ocena minimalna to {statistics1.Min}");
Console.WriteLine($"Ocena maksymalna to {statistics1.Max}");
Console.WriteLine($"Ocena średnia: {statistics1.Average:N2}");

var employee2 = new Employee("Jaśko", "Dębowy");
Console.WriteLine("\nDane dla {0} {1}: ", employee2.Name, employee2.Surname);
employee2.AddGrade(-20);
employee2.AddGrade("Okropnie");
employee2.AddGrade(4);
employee2.AddGrade(6);
employee2.AddGrade(3);
var statistics2 = employee2.GetStatistics();
Console.WriteLine($"Ocena minimalna to {statistics2.Min}");
Console.WriteLine($"Ocena maksymalna to {statistics2.Max}");
Console.WriteLine($"Ocena średnia: {statistics2.Average:N2}");


var employee3 = new Employee("Mnietek", "Kargulowski");
Console.WriteLine("\nDane dla {0} {1}: ", employee3.Name, employee3.Surname);
employee3.AddGrade(200);
employee3.AddGrade(3.14);
employee3.AddGrade(Math.Tau);
employee3.AddGrade(7);
employee3.AddGrade(3);
var statistics3 = employee3.GetStatistics();
Console.WriteLine($"Ocena minimalna to {statistics3.Min}");
Console.WriteLine($"Ocena maksymalna to {statistics3.Max}");
Console.WriteLine($"Ocena średnia: {statistics3.Average:N2}");

Console.ReadKey();