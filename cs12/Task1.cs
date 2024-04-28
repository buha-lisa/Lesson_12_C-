
namespace cs12
{
    internal class Task1
    {
        public void DigitArray()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            var even1 = numbers.Where(num => num % 2 == 0);
            foreach (var num in even1)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); 

            var even2 = numbers.Where(num => num % 2 != 0);
            foreach (var num in even2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Enter number to comparison: ");
            int.TryParse(Console.ReadLine(), out int input);
            var even3 = numbers.Where(num => num > input);
            foreach (var num in even3)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Enter start of range: ");
            int.TryParse(Console.ReadLine(), out int start);
            Console.Write("Enter end of range: ");
            int.TryParse(Console.ReadLine(), out int end);
            var even4 = numbers.Where(num => num > start && num < end);
            foreach (var num in even4)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            var even5 = numbers.Where(num => num % 7 == 0).OrderBy(_ => _);
            foreach (var num in even5)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            var even6 = numbers.Where(num => num % 8 == 0).OrderByDescending(_ => _);
            foreach (var num in even6)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
