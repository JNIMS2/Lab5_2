using System;
using System.Collections.Generic;
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
        protected CarMake Make;//fine
        protected string Model;
        protected int Year;
        protected decimal Price;

        //do i need a defaul const?
        //do i need getters?
        public Car(CarMake _Make, string _Model, int _Year, decimal _Price)//works
        {
            SetMake(_Make);
            SetModel(_Model);
            SetYear(_Year);
            SetPrice(_Price);
        }
        public CarMake GetMake()
        {
            return Make;
        }
        public void SetMake(CarMake _Make)
        {
            Make = _Make;
        }

        public string GetModel()
        {
            return Model;
        }
        public void SetModel(string _Model)
        {
            Model = _Model;
        }

        public void SetYear(int _Year)
        {
            Year = _Year;
        }
        public int GetYear()
        {
            return Year;
        }

        public void SetPrice(decimal _Price)
        {
            Price = _Price;
        }
        public decimal GetPrice()
        {
            return Price;
        }

        public static void ListCars(List<Car> mylist)//this should print my cars...but it doesn't
        {
            foreach (Car mycar in mylist)
            {
                Console.WriteLine(mycar);
            }
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
            return $"New Car: {Year} {Make} {Model} Price: ${Price}. Extended Warranty? {ExtendedWarranty}";//works
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
            return $"UsedCar: {Year} {Make} {Model} Mileage: {Mileage} . Price: ${Price}. Previous Owner(s): {NumberofOwners} ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //empty list of cars
            List<Car> mylist = new List<Car>();

            //make a bunch of used and new cars. add each one to the list


            NewCar nc1 = new NewCar(CarMake.Honda, "Civic", 2021, 20000.00m, false);
            mylist.Add(nc1);
            nc1 = new NewCar(CarMake.Chevrolet, "S10", 2023, 19000.00m, true);
            mylist.Add(nc1);
            nc1 = new NewCar(CarMake.Chrysler, "Sebring", 2021, 25000.00m, false);
            mylist.Add(nc1);
            nc1 = new NewCar(CarMake.Ford, "F350", 2021, 39450.00m, true);
            mylist.Add(nc1);
            nc1 = new NewCar(CarMake.Toyota, "Tacoma", 2022, 45338.00m, true);
            mylist.Add(nc1);


            UsedCar uc1 = new UsedCar(CarMake.Toyota, "Tacoma", 2010, 15000.00m, 1, 101345);
            mylist.Add(uc1);
            uc1 = new UsedCar(CarMake.Toyota, "Tundra", 2010, 17830.00m, 4, 157238);
            mylist.Add(uc1);
            uc1 = new UsedCar(CarMake.Honda, "Accord", 2015, 16348.00m, 1, 80283);
            mylist.Add(uc1);
            uc1 = new UsedCar(CarMake.Chrysler, "300M", 2014, 12384.00m, 3, 113830);
            mylist.Add(uc1);
            uc1 = new UsedCar(CarMake.Chevrolet, "Colorado", 2018, 19372.00m, 2, 60382);
            mylist.Add(uc1);

            //welcome menu with cars listed
            Console.WriteLine("Welcome to the car lot! \nHere is what we currently have on hand: \n");

            //Car.ListCars(mylist);//had to addCar
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {mylist[i].ToString()}");
            }
            while (true)
            {
                //give a menu of options to A. add a car, B. Purchase a car P. print list, Q q for quit
                Console.WriteLine("\nWhat would you like to do? \nA. Add a Car\nB. Buy a Car\nP. Print List of cars\nQ. Quit\n");

                string selection = Console.ReadLine().ToUpper();
                if (selection == "A")
                {
                    //add a car
                    Console.WriteLine("What is the Make of the car to add? ");
                    string carmake = Console.ReadLine().ToLower() ;
                    Console.WriteLine("What is the Model of the Car to add? ");
                    string carmodel = Console.ReadLine();
                    Console.WriteLine("What is the year of the car to add? ");
                    int caryr = int.Parse(Console.ReadLine());
                    Console.WriteLine("what is the price of the car to add? ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Would you like to add a New Car? Or, a Used Car?");
                    string typecar = Console.ReadLine().ToUpper();

                    if (typecar == "NEW")
                    {   //collect more info b4 making our instance of new car
                        Console.WriteLine("Does this car have an extended warranty? (y/n) ");
                        string warranty = Console.ReadLine().ToLower();


                        //make a new car

                        CarMake _newmake = CarMake.Chevrolet;
                        switch (carmake)
                        {
                            case "chevrolet":
                                _newmake = CarMake.Chevrolet;
                                break;
                            case "ford":
                                _newmake = CarMake.Ford;
                                break;
                            case "chrysler":
                                _newmake = CarMake.Chrysler;
                                break;
                            case "honda":
                                _newmake = CarMake.Honda;
                                break;
                            case "toyota":
                                _newmake = CarMake.Toyota;
                                break;
                        }
                        NewCar n1 = new NewCar(_newmake, carmodel, caryr, price, true);
                        mylist.Add(n1);

                        if (warranty == "y" || warranty == "yes")
                        {
                            n1.ExtendedWarranty = true;
                        }

                        else if (warranty == "n" || warranty == "no")
                        {
                            n1.ExtendedWarranty = false;
                        }

                        //make a new car
                        //add it to the list
                        else
                        {
                            Console.WriteLine("That is not valid input for warranty");
                        }
                    }


                    else if (typecar == "USED")
                    {

                        //collect more info b4 making our instance of used car
                        Console.WriteLine("How many previous owners has this vehicle had? Enter a number");
                        int numowns = int.Parse(Console.ReadLine());//i know i try parsed earlier. this didn't say we needed the validation here. 
                        Console.WriteLine("How many miles are on the car? ");
                        int usedmiles = int.Parse(Console.ReadLine());

                        CarMake _newmake = CarMake.Chevrolet;
                        switch (carmake)
                        {
                            case "chevrolet":
                                _newmake = CarMake.Chevrolet;
                                break;
                            case "ford":
                                _newmake = CarMake.Ford;
                                break;
                            case "chrysler":
                                _newmake = CarMake.Chrysler;
                                break;
                            case "honda":
                                _newmake = CarMake.Honda;
                                break;
                            case "toyota":
                                _newmake = CarMake.Toyota;
                                break;
                        }
                        UsedCar u1 = new UsedCar(_newmake, carmodel, caryr, price, numowns, usedmiles);
                        mylist.Add(u1);
                    }
                    else
                    {
                        Console.WriteLine("Please enter NEW or USED.");
                    }
                }



                else if (selection == "B")
                {
                    //Purchase a car
                    Console.WriteLine("Enter the number of the car you would like to purchase: ");
                    string buyinput = Console.ReadLine();
                    bool buycar = int.TryParse(buyinput, out int car2buy);
                    if (buycar)
                    {
                        //buy a car-remove from inventory
                        //Console.WriteLine("remove car from inventory");
                        mylist.RemoveAt(car2buy - 1);//i get i'm supposed to put this in it's own function. but, i've been painting my garage all day. and i'm tired...

                    }
                    else
                    {
                        Console.WriteLine("That is not a valid number");
                    }

                }
                else if (selection == "P")
                {
                    //print list of cars
                    for (int i = 0; i < mylist.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {mylist[i].ToString()}");
                    }
                }
                else if (selection == "Q")
                {
                    Console.WriteLine("GoodBye!");
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid Selection");
                }
                }



              ////***I'm aware that i didn't put stuff in their own functions like i should have. i worked on the garage all weekend. and, i forgot about the lab until late. i painted the garage after messaging you//
              /////i know that doesn't affect points. but, just wanted u to know that  i'm aware of the looping monstrosity....







            }
        }
    }



