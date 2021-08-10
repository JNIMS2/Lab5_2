using System;

namespace Lab5_2
{
    //create an enum called CarMake
    enum CarMake
    {
    Ford,
    Chevrolet,
    Chrysler,
    Honda,
    Toyota
    }

    class Car
    {//make these public until tested. then private...
        public CarMake Make;//fine
        public string Model;
        public int Year;
        public decimal Price;

        public Car(CarMake _Make, string _Model, int _Year, decimal _Price )
        {
            Make = _Make;
            Model = _Model;
            Year = _Year;
            Price = _Price;//stuff
        } 

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Car testcar = new Car();
            //testcar.Make = CarMake.Chevrolet;
            //Console.WriteLine(testcar.Make);
            Car test = new Car(CarMake.Ford, "Fiesta", 2001, 19000.00m);
            Console.WriteLine(test.Make);
            Console.WriteLine(test.Model);
            Console.WriteLine(test.Price);
            Console.WriteLine(test.Year);


        }
    }
}
