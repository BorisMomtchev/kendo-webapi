﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NiCris.BusinessObjects;

namespace NiCris.DataAccess.InMemory
{
    public class ContinentData
    {
        public static List<Continent> Current = GetData();

        public static List<Continent> GetData()
        {
            List<Continent> list = new List<Continent>();

            list.Add(new Continent() { id = 1, name = "Africa", details = "Area: 30,221,532 km2", image = "africa-globe", description = "Africa is the world's second-largest and second-most-populous continent. At about 30.2 million km² (11.7 million sq mi) including adjacent islands, it covers six percent of the Earth's total surface area and 20.4 percent of the total land area.[2] With 1.0 billion people (as of 2009, see table), it accounts for about 14.72% of the world's human population." });
            list.Add(new Continent() { id = 2, name = "Antarctica", details = "Area: 14,000,000 km2", image = "antarctica-globe", description = "Antarctica (Listeni/æntˈɑrtɨkə/ or /ænˈtɑrktɨkə/)[Note 1] is Earth's southernmost continent, containing the geographic South Pole. It is situated in the Antarctic region of the Southern Hemisphere, almost entirely south of the Antarctic Circle, and is surrounded by the Southern Ocean." });
            list.Add(new Continent() { id = 3, name = "Asia", details = "Area: 44,579,000 km2", image = "asia-globe", description = "Asia (Listeni/ˈeɪʒə/ or /ˈeɪʃə/) is the world's largest and most populous continent, located primarily in the eastern and northern hemispheres. It covers 8.7% of the Earth's total surface area (or 30% of its land area) and with approximately 4.3 billion people, it hosts 60% of the world's current human population. During the 20th century Asia's population nearly quadrupled." });
            list.Add(new Continent() { id = 4, name = "Australia", details = "Area: 8,468,300 km2", image = "australia-globe", description = "Australia is a continent comprising mainland Australia, Tasmania, New Guinea, Timor, Seram, and neighbouring islands. The continent is sometimes known in technical contexts by the names Sahul, Australinea or Meganesia, to distinguish it from the Australian mainland. It is the smallest of the seven traditional continents in the English conception. New Zealand is not part of the continent of Australia, but of the separate, submerged continent of Zealandia. Zealandia and Australia are both part of the wider regions known as Australasia and Oceania." });
            list.Add(new Continent() { id = 5, name = "Europe", details = "Area: 10,180,000 km2", image = "europe-globe", description = "Europe (Listeni/ˈjʊərəp/ EWR-əp or /ˈjɜrəp/ YUR-əp[1]) is, by convention, one of the world's seven continents. Comprising the westernmost peninsula of Eurasia, Europe is generally 'divided' from Asia by the watershed divides of the Ural and Caucasus Mountains, the Ural River, the Caspian and Black Seas, and the waterways connecting the Black and Aegean Seas.[2] Europe is bordered by the Arctic Ocean to the north, the Atlantic Ocean to the west, the Mediterranean Sea to the south, and the Black Sea and connected waterways to the southeast. Yet the borders of Europe—a concept dating back to classical antiquity—are somewhat arbitrary, as the primarily physiographic term 'continent' can incorporate cultural and political elements." });
            list.Add(new Continent() { id = 6, name = "North America", details = "Area: 24,709,000 km2", image = "north-america-globe", description = "North America is a continent wholly within the Northern Hemisphere and almost wholly within the Western Hemisphere. It is also considered a northern subcontinent of the Americas.[2] It is bordered to the north by the Arctic Ocean, to the east by the Atlantic Ocean, to the west and south by the Pacific Ocean, and to the southeast by South America and the Caribbean Sea." });
            list.Add(new Continent() { id = 7, name = "South America", details = "Area: 17,840,000 km2", image = "south-america-globe", description = "South America is a continent located in the Western Hemisphere, mostly in the Southern Hemisphere, with a relatively small portion in the Northern Hemisphere. The continent is also considered a subcontinent of the Americas." });

            return list;
        }

    }
}
