
class Program
{
    class Student(string name, int age, int course = 1)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public int Course { get; set; } = course;
    }

    class Group(string name)
    {
        public string Name { get; set; } = name;
        public List<Student> Students { get; set; } = [];

        public void AddStudent(Student student) =>
            Students.Add(student);

        public void PrintAllStudents()
        {
            Console.WriteLine($"Group: {Name}");

            foreach (var student in Students)
                Console.WriteLine($"- {student.Name}, Age: {student.Age}");
        }

        public (int count, int avgCourse) GetStatistics()
        {
            int count = Students.Count;
            return (count, count == 0 ? 0 : (int)Students.Average(s => s.Course));
        }
    }

    static void Main()
    {
        var group = new Group("Mathematics");

        group.AddStudent(new("Adil", 19, 3));
        group.AddStudent(new("Alisher", 18, 3));
        group.AddStudent(new("Amir", 17, 3));
        group.AddStudent(new("Banana", 22, 2));
        group.AddStudent(new("Agent", 7, 1));
        group.AddStudent(new("Sabir", 22, 4));
        group.AddStudent(new("Katya", 17, 3));
        group.AddStudent(new("HelloKitty", 51, 4));
        group.AddStudent(new("Covid", 6, 2));
        group.AddStudent(new("Horror", 19, 2));
        
        group.PrintAllStudents();

        var (count, avgCourse) = group.GetStatistics();
        Console.WriteLine($"Total Students: {count}, Average Course: {avgCourse}");
    }
}