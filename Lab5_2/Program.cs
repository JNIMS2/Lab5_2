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
    {//make these public until tested. then protected...
        public CarMake Make;//fine
        public string Model;
        public int Year;
        public decimal Price;

        //do i need a defaul const?
        public Car(CarMake _Make, string _Model, int _Year, decimal _Price)//works
        {
            Make = _Make;
            Model = _Model;
            Year = _Year;
            Price = _Price;
        }
    }

    class NewCar : Car //works
    {
         public bool ExtendedWarranty;//had to make it public to access it in new car...

        //constructor
        public NewCar(CarMake _Make, string _Model, int _Year, decimal _Price, bool _ExtendedWarranty) : base(_Make, _Model, _Year, _Price)
        {
            ExtendedWarranty = _ExtendedWarranty;//is this right?
        }
        //tostring
        public override string ToString()
        {
            return $"This New Car is a {Year} {Make} {Model} that is ${Price}. Has an Extended Warranty? {ExtendedWarranty}";//works
        }

    }

    class UsedCar : Car //worked
    {
        public int NumberofOwners;
        public int Mileage;

        public UsedCar(CarMake _Make, string _Model, int _Year, decimal _Price, int _NumberofOwners, int _Mileage) : base(_Make, _Model, _Year, _Price)
        {
            NumberofOwners = _NumberofOwners;
            Mileage = _Mileage;
        }
        public override string ToString()
        {
            return $"This New Car is a {Year} {Make} {Model} with {Mileage} miles. The Price is ${Price}. The car has had {NumberofOwners} owner(s)";
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

                NewCar nc1 = new NewCar(CarMake.Honda, "Civic", 1999, 2000.00m, false);
             
                Console.WriteLine(nc1.ToString());
                Console.WriteLine(nc1.Model);//this works
                Console.WriteLine( nc1.Year);
                Console.WriteLine(nc1.Price);
            Console.WriteLine(nc1.ExtendedWarranty);

            UsedCar uc1 = new UsedCar(CarMake.Toyota, "Tacoma", 2010, 15000.00m, 1, 101345);
            Console.WriteLine(uc1.ToString());
            Console.WriteLine(uc1.Model);//this works
            Console.WriteLine(uc1.Year);
            Console.WriteLine(uc1.Price);
            Console.WriteLine(uc1.NumberofOwners);
            Console.WriteLine(uc1.Mileage);










        }
        }
    }

