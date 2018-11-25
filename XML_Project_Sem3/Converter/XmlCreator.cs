using System;
using System.Collections.Generic;
using XML_Project_Sem3.Config;

namespace XML_Project_Sem3.DataContainers
{
    public class XmlCreator
    {
        #region Private Fields

        private WorldData world = new WorldData();
        private SyntaxController sc = new SyntaxController();
        private const string border = "~~~~~~~~~~~~~~~~";

        #endregion

        #region Public Properties

        public WorldData World => world;

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
            world.Countries = new List<CountryData>();

            string tabS = "\t";
            do
            {
                Console.WriteLine(border);

                var country = new CountryData();
                Console.Write(tabS + "Write country name: ");
                country.Name = sc.UserInput();

                Console.Write(tabS + "Write capital name: ");
                country.Capital = sc.UserInput();

                Console.Write(tabS + "Write country official language: ");
                country.OfficialLanguages = sc.UserInput();

                GetCountryPartition(country);

                world.Countries.Add(country);

            } while (Finish("country", tabS));
        }

        private void GetCountryPartition(CountryData country)
        {
            country.CountryDivision = new List<CountryDivisionData>();

            string tabS = "\t\t";
            do
            {
                var countryPartition = new CountryDivisionData();

                Console.Write(tabS + "Write country partition name: ");
                countryPartition.Name = sc.UserInput();

                Console.Write(tabS + "Write capital name: ");
                countryPartition.Capital = sc.UserInput();

                GetCities(countryPartition);

                country.CountryDivision.Add(countryPartition);

            } while (Finish("country division", tabS));
        }

        private void GetCities(CountryDivisionData countryPartition)
        {
            countryPartition.Cities = new List<CityData>();

            string tabS = "\t\t\t";
            do
            {
                var city = new CityData();

                Console.Write(tabS + "Write city name: ");
                city.Name = sc.UserInput();

                GetCityPopulation(out int populVal);
                city.Population = populVal;

                GetPubs(city);

                countryPartition.Cities.Add(city);

            } while (Finish("city", tabS));
        }

        private void GetCityPopulation(out int cityPopulValue)
        {
            string tabS = "\t\t\t";
            Console.Write(tabS + "Write population: ");
            do
            {
                if (int.TryParse(Console.ReadLine(), out cityPopulValue))
                    break;

                Console.WriteLine(tabS + "Write some intiger value..");
                Console.WriteLine(tabS + "Try again, write population:");

            } while (true);
        }

        private void GetPubs(CityData city)
        {
            city.Pubs = new List<string>();

            string tabS = "\t\t\t\t";
            do
            {
                Console.Write(tabS + "Write pub name: ");
                city.Pubs.Add(sc.UserInput());
                
            } while (Finish("pub", tabS));
        }

        private bool Finish(string itemToAdd, string tabV)
        {
            Console.WriteLine(tabV + "Press enter if you want to add next " + itemToAdd);
            return Console.ReadKey().Key == ConsoleKey.Enter;
        }

        #endregion
    }
}
