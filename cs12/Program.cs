using System;

namespace cs12
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        new Task1().DigitArray();
                        break;
                    case 2:
                        new Task2().CityArray();
                        break;
                    case 3:
                        var students = new List<Student>()
                        {
                            new Student() { Name = "Boris", Surname = "Brown", Age = 20, NameOfInstitution = "KPI" },
                            new Student() { Name = "Ann", Surname = "White", Age = 21, NameOfInstitution = "Oxford" },
                            new Student() { Name = "Sirius", Surname = "Black", Age = 19, NameOfInstitution = "MIT" },
                            new Student() { Name = "Mett", Surname = "Brouse", Age = 23, NameOfInstitution = "Harvard" },
                            new Student() { Name = "Boris", Surname = "Smith", Age = 22, NameOfInstitution = "Oxford" },
                        };
                        Console.WriteLine("List of all students:");
                        foreach (var student in students)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        Console.WriteLine("\n\nList of students with name 'Boris':");
                        var even1 = students.Where(n => n.Name == "Boris");
                        foreach ( var student in even1)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        Console.WriteLine("\n\nList of students with surname on 'Bro':");
                        var even2 = students.Where(n => n.Surname.StartsWith("Bro"));
                        foreach (var student in even2)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        Console.WriteLine("\n\nList of students that older than 19 years:");
                        var even3 = students.Where(n => n.Age > 19);
                        foreach (var student in even3)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        Console.WriteLine("\n\nList of students that older than 20 years:");
                        var even4 = students.Where(n => n.Age > 20 && n.Age < 23);
                        foreach (var student in even4)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        Console.WriteLine("\n\nList of students that studing in 'MIT':");
                        var even5 = students.Where(n => n.NameOfInstitution == "MIT");
                        foreach (var student in even5)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        Console.WriteLine("\n\nList of students that studing in 'Oxford':");
                        var even6 = students.Where(n => n.NameOfInstitution == "Oxford")
                                            .OrderByDescending(n => n.Age > 18);
                        foreach (var student in even6)
                        {
                            Console.WriteLine($"Name:\t\t\t  {student.Name}");
                            Console.WriteLine($"Surname:\t\t  {student.Surname}");
                            Console.WriteLine($"Age:\t\t\t  {student.Age}");
                            Console.WriteLine($"Educational institution:  {student.NameOfInstitution}");
                        }

                        break;
                }

                if (task == 0) break;
            }



            //var ints = new List<string>() { "1", "2", "3", "4", "5" };
            //var evenNumber2 = from num in ints
            //                  where num == "1" || num == "3"
            //                  select num;
            //foreach (var num in evenNumber2) 
            //{
            //    Console.WriteLine(num);
            //}

            //var res = ints.Where(num => num == "1" || num == "3");
            //foreach (var num in res)
            //{
            //    Console.WriteLine(num);
            //}

            //var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        var evenNumber = numbers[i];
            //    }
            //}
            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        var evenNumber = num;
            //    }
            //}

            //var evenNumber1 = from num in numbers
            //                  where num % 2 == 0
            //                  select num;
            //foreach (var num in evenNumber1)
            //{
            //    Console.WriteLine(num);
            //}

            //var result = numbers.OrderByDescending(_ => _);
            //foreach (var num in result)
            //{
            //    Console.WriteLine(num);
            //}

            //var even = numbers.Where(num => num % 2 == 0)
            //                    .OrderByDescending(_ => _);
            //foreach (var num in even)
            //{
            //    Console.WriteLine(num);
            //}

        }
    }
}
