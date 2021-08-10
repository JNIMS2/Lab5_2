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

        //do i need a defaul const?
        public Car(CarMake _Make, string _Model, int _Year, decimal _Price)
        {
            Make = _Make;
            Model = _Model;
            Year = _Year;
            Price = _Price;
        }
    }

    class NewCar : Car
    {
        bool ExtendedWarranty;//extra thing for this class//what do i do with this bool?
       
        //constructor
        public NewCar(CarMake _Make, string _Model, int _Year, decimal _Price, bool _ExtendedWarranty) :base(_Make, _Model, _Year,_Price)
        {
            ExtendedWarranty = _ExtendedWarranty;//is this right?
        }
        //tostring
        public override string ToString()
        {
            return $"This New Car is a {Year} {Make} {Model} that is ${Price}. Has an Extended Warranty? {ExtendedWarranty}";
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

                NewCar nc1 = new NewCar(CarMake.Honda, "Civic", 1999, 2000.00m, false);
             
                Console.WriteLine(nc1.ToString());
                Console.WriteLine(nc1.Model);//this works
                Console.WriteLine( nc1.Year);
                Console.WriteLine(nc1.Price);
                Console.WriteLine(nc1.ExtendedWarranty);
            }
        }
    }
}
