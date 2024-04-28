
namespace cs12
{
    internal class Task1
    {
        public static void DigitArray()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            _showInfo(numbers);
            Console.WriteLine();

            var even1 = numbers.Where(num => num % 2 == 0);
            _showInfo(even1);
            Console.WriteLine(); 

            var even2 = numbers.Where(num => num % 2 != 0);
            _showInfo(even2);
            Console.WriteLine();

            Console.Write("Enter number to comparison: ");
            int.TryParse(Console.ReadLine(), out int input);
            var even3 = numbers.Where(num => num > input);
            _showInfo(even3);
            Console.WriteLine();

            Console.Write("Enter start of range: ");
            int.TryParse(Console.ReadLine(), out int start);
            Console.Write("Enter end of range: ");
            int.TryParse(Console.ReadLine(), out int end);
            var even4 = numbers.Where(num => num > start && num < end);
            _showInfo(even4);
            Console.WriteLine();

            var even5 = numbers.Where(num => num % 7 == 0).OrderBy(_ => _);
            _showInfo(even5);
            Console.WriteLine();

            var even6 = numbers.Where(num => num % 8 == 0).OrderByDescending(_ => _);
            _showInfo(even6);
            Console.WriteLine();
        }

        private static void _showInfo(IEnumerable<int> ints)
        {
            foreach (var num in ints)
            {
                Console.Write(num + " ");
            }
        }
    }
}
