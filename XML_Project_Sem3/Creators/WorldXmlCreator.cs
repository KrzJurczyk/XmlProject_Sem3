using System;
using System.Collections.Generic;
using XML_Project_Sem3.ClassToSerialize;

namespace XML_Project_Sem3.Creators
{
    public class WorldXmlCreator
    {
        #region Private Fields

        private WorldSerializer world = new WorldSerializer();

        #endregion

        #region Public Properties

        public WorldSerializer World => world;

        #endregion

        #region Public Methods

        public void CreateWorld()
        {
            Console.WriteLine("Hello, how u doin?");
            GetAge();
            GetCountry();
        }

        #endregion

        #region Private Methods

        private void GetAge()
        {
            Console.Write("Write age of your planet: ");

            string secretStop = "Jesus";

            do
            {
                var userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int ageInt))
                {
                    world.Age = ageInt;
                    break;
                }

                if (userInput.Equals(secretStop, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Jesus is always accepted!");
                    world.Age = DateTime.Now.Year;
                    break;
                } 

                Console.WriteLine("You have to write some intiger value!");
                Console.Write("Try again, write age: ");

            } while (true);
        }

        private void GetCountry()
        {
            world.Countries = new List<CountrySerializer>();

            do
            {
                var country = new CountrySerializer();

                Console.Write("Write country name: ");
                country.Name = Console.ReadLine();

                Console.Write("Write capital name: ");
                country.Capital = Console.ReadLine();

                Console.Write("Write country official language: ");
                country.OfficialLanguages = Console.ReadLine();

                GetCountryPartition(country);

                world.Countries.Add(country);

                Console.WriteLine("Press space if you want add next country");

            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        private void GetCountryPartition(CountrySerializer country)
        {
            country.CountryPartitions = new List<CountryPartitionSerializer>();

            do
            {
                var countryPartition = new CountryPartitionSerializer();

                Console.Write("Write country partition name: ");
                countryPartition.Name = Console.ReadLine();

                Console.Write("Write capital name: ");
                countryPartition.Capital = Console.ReadLine();

                GetCities(countryPartition);

                country.CountryPartitions.Add(countryPartition);

                Console.WriteLine("Press space if you want add next country partition");

            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        private void GetCities(CountryPartitionSerializer countryPartition)
        {
            countryPartition.Cities = new List<CitySerializer>();

            do
            {
                var city = new CitySerializer();

                Console.Write("Write city name: ");
                city.Name = Console.ReadLine();

                GetCityPopulation(out int populVal);
                city.Population = populVal;

                GetPubs(city);

                countryPartition.Cities.Add(city);

                Console.WriteLine("Press space if you want add next city");

            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        private void GetCityPopulation(out int cityPopulValue)
        {
            Console.Write("Write population: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out cityPopulValue))
                    break;

                Console.WriteLine("Write some intiger value..");
                Console.WriteLine("Try again, write population:");

            } while (true);
        }

        private void GetPubs(CitySerializer city)
        {
            city.Pubs = new List<string>();

            do
            {
                Console.Write("Write pub name: ");
                city.Pubs.Add(Console.ReadLine());

                Console.WriteLine("Press space if you want add next pub");

            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);
        }

        #endregion
    }
}
