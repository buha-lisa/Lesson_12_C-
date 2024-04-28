
namespace cs12
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string NameOfInstitution { get; set; }

        public static void ShowInfo(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name:\t\t\t  {student.Name}");
                Console.WriteLine($"Surname:\t\t  {student.Surname}");
                Console.WriteLine($"Age:\t\t\t  {student.Age}");
                Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
            }
        }

    }
}
