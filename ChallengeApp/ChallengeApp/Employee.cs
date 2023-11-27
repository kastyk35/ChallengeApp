namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name)
        {
            this.Name = name;
        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Niepoprawna wartość, ocena nie jest brana pod uwagę.");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Wprowadzona wartość nie jest typu float");
            }
        }
        public void AddGrade(double grade)
        {
            var valueInFloat = (float)grade;
            AddGrade(valueInFloat);
        }
        public void AddGrade(long grade)
        {
            var valueInFloat = (float)grade;
            AddGrade(valueInFloat);
        }
        public void AddGrade(ulong grade)
        {
            var valueInFloat = (float)grade;
            AddGrade(valueInFloat);
        }
        public void AddGrade(int grade)
        {
            var valueInFloat = (float)grade;
            AddGrade(valueInFloat);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
