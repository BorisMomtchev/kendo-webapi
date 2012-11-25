using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NiCris.BusinessObjects;

namespace NiCris.DataAccess.InMemory
{
    public class CountryData
    {
        public static List<Country> Current = GetData();

        public static List<Country> GetData()
        {
            List<Country> list = new List<Country>();

            list.Add(new Country() 
            {
                id = 1,
                continentId = 1,
                // Continent = ContinentData.GetData().Where(x => x.Id == 1).SingleOrDefault(),
                name = "Sudan", 
                image = "flag_sudan.png", 
                capital = "Khartoum",
                population = "34,318,385 (2011)",
                gdp = "N/A",
                visited = true
            });

            list.Add(new Country()
            {
                id = 2,
                continentId = 1,
                name = "Zimbabwe",
                image = "flag_zimbabwe.png",
                capital = "Harare",
                population = "12,754,378 (2011)",
                gdp = "9.9 billion USD (2011)",
                visited = true
            });

            list.Add(new Country()
            {
                id = 3,
                continentId = 2,
                name = "Antarctica",
                image = "flag_antarctica.png",
                capital = "N/A",
                population = "N/A",
                gdp = "N/A",
                visited = true
            });

            list.Add(new Country()
            {
                id = 4,
                continentId = 3,
                name = "India",
                image = "flag_india.png",
                capital = "New Delhi",
                population = "> 1.2 billion people",
                gdp = "1.848 trillion USD (2011)",
                visited = true
            });

            list.Add(new Country()
            {
                id = 5,
                continentId = 3,
                name = "North Korea",
                image = "flag_north_korea.png",
                capital = "Pyongyang",
                population = "24,451,285 (2011)",
                gdp = "32.7 billion USD (2011)",
                visited = true
            });

            list.Add(new Country()
            {
                id = 6,
                continentId = 4,
                name = "Australia",
                image = "flag_australia.png",
                capital = "Canberra",
                population = "22,620,600 (2011)",
                gdp = "1.372 trillion USD (2011)",
                visited = true
            });

            list.Add(new Country()
            {
                id = 7,
                continentId = 5,
                name = "Bulgaria",
                image = "flag_bulgaria.png",
                capital = "Sofia",
                population = "7,476,000 (2011)",
                gdp = "53.51 billion USD (2011)",
                visited = true
            });
            
            return list;
        }
    }
}
