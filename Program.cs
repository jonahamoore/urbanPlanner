using System;
using System.Collections.Generic;

namespace Planner
{

    class Program
    {

        static void Main(string[] args)
        {
            Building jonahHouse = new Building("111 yeah whatever drive")
            {
            stories = 2,
            width = 150
            };

            jonahHouse.depth = 180;

            jonahHouse.Construct();

            jonahHouse.Purchase("Jonah Moore");

            Building abHouse = new Building("111 yeah whatever drive")
            {
            stories = 1,
            width = 50
            };

            abHouse.depth = 80;

            abHouse.Construct();

            abHouse.Purchase("ab");
            // jonahHouse.getInfo();

            List<Building> Neighborhood = new List<Building>(){
                jonahHouse,
                abHouse
            };

            Console.WriteLine(Neighborhood.Count);

            // foreach ( Building house in Neighborhood)
            // {
            //     house.getInfo();
            // }

            Neighborhood.ForEach (house => house.getInfo());
        }
    }
}