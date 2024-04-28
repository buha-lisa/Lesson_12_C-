
namespace cs12
{
    internal class Task2
    {
        public void CityArray()
        {
            var cities = new List<string>()
            { "Kiev", "London", "Khmelnytskyi", "Amsterdam", "Tokio", "New York", "Nairobi", "Nebraska", "Nizhin", "Avdiyivka" };

            foreach (var city in cities)
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();

            Console.Write("Enter lenght to comparison: ");
            int.TryParse(Console.ReadLine(), out int input);
            var even1 = cities.Where(city => city.Length == input);
            foreach (var city in even1)
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();

            var even2 = cities.Where(city => city.StartsWith('A'));
            foreach (var city in even2) 
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();

            var even3 = cities.Where(city => city.EndsWith('M'));
            foreach (var city in even3)
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();

            var even4 = cities.Where(city => city.StartsWith('N') && city.EndsWith('K'));
            foreach (var city in even4)
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();

            var even5 = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(_ => _);
            foreach (var city in even5)
            {
                Console.Write(city + "  ");
            }
            Console.WriteLine();

        }
    }
}
