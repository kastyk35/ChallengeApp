using ChallengeApp;

var employee1 = new Employee("Janusz", "Kastyk");
var employee2 = new Employee("Jaśko", "Dębowy");
var employee3 = new Employee("Mnietek", "Kargulowski");

employee1.AddGrade(2);
employee1.AddGrade(5);
employee1.AddGrade(6);
employee1.AddGrade(-4);
employee1.AddGrade(9);

employee2.AddGrade(10);
employee2.AddGrade(-7);
employee2.AddGrade(4);
employee2.AddGrade(-2);
employee2.AddGrade(3);

employee3.AddGrade(4);
employee3.AddGrade(-11);
employee3.AddGrade(12);
employee3.AddGrade(7);
employee3.AddGrade(-3);

var statistics1 = employee1.GetStatistics();
var statistics2 = employee2.GetStatistics();
var statistics3 = employee3.GetStatistics();

Console.WriteLine("Dane dla {0} {1}: ", employee1.Name, employee1.Surname);
Console.WriteLine($"Ocena minimalna to {statistics1.Min}");
Console.WriteLine($"Ocena maksymalna to {statistics1.Max}");
Console.WriteLine($"Ocena średnia: {statistics1.Average:N2}");

Console.WriteLine("\nDane dla {0} {1}: ", employee2.Name, employee2.Surname);
Console.WriteLine($"Ocena minimalna to {statistics2.Min}");
Console.WriteLine($"Ocena maksymalna to {statistics2.Max}");
Console.WriteLine($"Ocena średnia: {statistics2.Average:N2}");

Console.WriteLine("\nDane dla {0} {1}: ", employee3.Name, employee3.Surname);
Console.WriteLine($"Ocena minimalna to {statistics3.Min}");
Console.WriteLine($"Ocena maksymalna to {statistics3.Max}");
Console.WriteLine($"Ocena średnia: {statistics3.Average:N2}");

Console.ReadKey();