
namespace cs12
{
    internal class Task2
    {
        public static void CityArray()
        {
            var cities = new List<string>()
            { "Kiev", "London", "Khmelnytskyi", "Amsterdam", "Tokio", "New York", "Nairobi", "Nebraska", "Nizhin", "Avdiyivka" };

            _showInfo(cities);
            Console.WriteLine();

            Console.Write("Enter lenght to comparison: ");
            int.TryParse(Console.ReadLine(), out int input);
            var even1 = cities.Where(city => city.Length == input);
            _showInfo(even1);
            Console.WriteLine();

            var even2 = cities.Where(city => city.StartsWith('A'));
            _showInfo(even2);
            Console.WriteLine();

            var even3 = cities.Where(city => city.EndsWith('M'));
            _showInfo(even3);
            Console.WriteLine();

            var even4 = cities.Where(city => city.StartsWith('N') && city.EndsWith('K'));
            _showInfo(even4);
            Console.WriteLine();

            var even5 = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(_ => _);
            _showInfo(even5);
            Console.WriteLine();

        }
        private static void _showInfo(IEnumerable<string> cities)
        {
            foreach (var city in cities)
            {
                Console.Write(city + " ");
            }
        }
    }
}
