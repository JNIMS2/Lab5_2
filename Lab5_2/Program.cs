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
            Price = _Price;
        } 

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Car testcar = new Car();
            //testcar.Make = CarMake.Chevrolet;
            //Console.WriteLine(testcar.Make);
            
        }
    }
}
