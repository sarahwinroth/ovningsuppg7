using System;

namespace ovningsuppg7
{
    class Vehicle
    {
        //Fields el. Fält
        public string vehicleType;
        public string manufacture;
        public int amountOfWheels;
        public int yearModel;
        public string color;
        public string fuel;
        public int fuelLevel;

        static int vehivelCount = 0;

        public Vehicle() { }

        public Vehicle(string vehicleType, string manufacture, int amountOfWheels, int yearModel, string color, string fuel, int fuelLevel)
        {
            this.vehicleType = vehicleType;
            this.manufacture = manufacture;
            this.amountOfWheels = amountOfWheels;
            this.yearModel = yearModel;
            this.color = color;
            this.fuel = fuel;
            this.fuelLevel = fuelLevel;

            vehivelCount++;
        }

        public string Describe()
        {
            string describe = "Typ av Fordon: "+ vehicleType + " Tillverkare: " + manufacture + " Antal hjul: " + amountOfWheels + " Årsmodell: " + yearModel + " Färg: " + color + " Drivmedel: " + fuel;
            return describe;
        }

        public int GoForward()
        {
            if(fuel == "Bensin" || fuel == "Diesel")
            {
                fuelLevel -= 10;
                return fuelLevel;
            }
            else
            {
                return fuelLevel;
            }
        }

    }
    class Fastigheter
    {
        public string fastighetsTyp;
        public int antalBostader;
        public int kvm;
        public int antalRum;
        public int antalKok;
        public int antalToaletter;

        public Fastigheter() { }

        public Fastigheter(string fastighetsTyp, int antalBostader, int kvm, int antalRum, int antalKok, int antalToaletter)
        {
            this.fastighetsTyp = fastighetsTyp;
            this.antalBostader = antalBostader;
            this.kvm = kvm;
            this.antalRum = antalRum;
            this.antalKok = antalKok;
            this.antalToaletter = antalToaletter;
        }

        public string Describe()
        {
            string describe = "Typ av fastighet: "+ fastighetsTyp +"\nAntal bostäder: "+ antalBostader + "\nKvm: " + kvm + "\nAntal rum: " + antalRum + "\nAntal kök: " + antalKok + "\nAntal toaletter: " + antalToaletter;
            return describe;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Airplane = new Vehicle("Flygplan", "Airbus", 2, 2020, "Vit", "Bensin", 400);
            Vehicle Tank = new Vehicle("Pansarvagn", "Krauss-Maffei", 8, 1994, "Grön", "Diesel", 200);
            Vehicle Scooter = new Vehicle("Scooter", "Eloped", 2, 2001, "Gul", "Electric", 0);

            Airplane.GoForward();
            //Console.WriteLine(Airplane.fuelLevel);
            //Console.WriteLine(Tank.manufacture);
            //Console.WriteLine(Scooter.Describe());

            Fastigheter Villa = new Fastigheter("Villa", 1, 180, 6, 1, 2);
            Fastigheter Hyreshus = new Fastigheter("Hyreshus", 4, 480, 12, 4, 4);

            Fastigheter Radhus = new Fastigheter();
            Radhus.fastighetsTyp = "Radhus";
            Radhus.antalBostader = 1;
            Radhus.kvm = 120;
            Radhus.antalRum = 4;
            Radhus.antalKok = 1;
            Radhus.antalToaletter = 2;

            Console.WriteLine("Ange numret på den fastighet du vill ha mer information om: ");
            Console.WriteLine("1. Villa");
            Console.WriteLine("2. Radhus");
            Console.WriteLine("3. Hyreshus");
            string input = Console.ReadLine();

            switch(Convert.ToInt32(input))
            {
                case 1:
                    Console.WriteLine(Villa.Describe());
                    break;
                case 2:
                    Console.WriteLine(Radhus.Describe());
                    break;
                case 3:
                    Console.WriteLine(Hyreshus.Describe());
                    break;
            }  

        }
    }
}
