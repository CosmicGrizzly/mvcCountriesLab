using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCcountries
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Country> CountrydB = new List<Country>();

            CountrydB.Add(new Country ( "USA", "North America", new List<string> { "red", "white", "blue"}));

            CountrydB.Add(new Country("France", "Europe", new List<string> { "Blue", "white", "red" }));

            CountrydB.Add(new Country("Spain", "Europe", new List<string> { "Yellow", "Red", }));

            CountryController controller = new CountryController(CountrydB);

            controller.WelcomeAction();

        }
    }
}
