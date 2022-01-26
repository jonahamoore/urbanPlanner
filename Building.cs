using System;


namespace Planner
{
    public class Building
    {
        public Building(string addressParam){
            _address = addressParam;
        }
        private string designer = "Jonah";
        private DateTime dateConstructed {get; set;}
        private string _address {get; set;}
        private string owner {get; set;}


        public int stories { get; set; }
        public double width {get; set;}
        public double depth {get; set;}
        public double volume {
            get
            {
                return width * depth * (3 * stories );
            }
        }

        public void Construct() {
            dateConstructed = DateTime.Now;
        }

        public void Purchase(string ownerParam) {
            owner = ownerParam;
        }

        public void getInfo () 
        {
            Console.WriteLine(_address);
            Console.WriteLine("----------------");
            Console.WriteLine($"designed by {designer}");
            Console.WriteLine($"Constructed on {dateConstructed}");
            Console.WriteLine($"{owner}");
            Console.WriteLine($"{volume} cubic meters of space");
        }
    }
}

