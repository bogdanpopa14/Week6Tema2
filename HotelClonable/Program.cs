using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate r1 = new Rate { Amount = 12, Curency = "$" };
            Rate r2 = new Rate { Amount = 15, Curency = "$" };
            Rate r3 = new Rate { Amount = 20, Curency = "$" };
            Room c1 = new Room { Adults = 2, Children = 1, Name = "Familly", Cost = r2 };
            Room c2 = new Room { Adults = 1, Children = 1, Name = "Half", Cost = r1 };
            Room c3 = new Room { Adults = 2, Children = 0, Name = "Twin", Cost = r3 };
            Hotel h1 = new Hotel { City = "Roma", Name = "Imperial" };
            Hotel h2 = new Hotel { City = "Barcelona", Name = "Intercontinetal" };
            h1.AddCameraPret(c1);
            h1.AddCameraPret(c2);
            h2.AddCameraPret(c1);
            h2.AddCameraPret(c2);
            h2.AddCameraPret(c3);

            var hotel = h1.Clone();
            h1.City = "Iasi";
            h1.AddCameraPret(c3);
            h1.Print();
            h2.Print();
            Console.WriteLine();
            h2.PriceNrRooms();
            Console.ReadLine();
        }
    }

    class Rate
    {
        public int Amount { get; set; }
        public string Curency { get; set; }
        public void Print()
        {
            Console.WriteLine($"Cost: {Amount}({Curency})");
        }
    }

    class Room
    {
        public string Name { get; set; }
        public Rate Cost { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int PriceDays(int NrOfDays)
        {
            int total = 1;
            total = Cost.Amount * NrOfDays;
            return total;
        }
        public void Print()
        {
            Console.WriteLine($"Camera: {Name}");
            Console.WriteLine($"Adulti: {Adults}");
            Console.WriteLine($"Copii: {Children}");
            Cost.Print();
        }
    }

    class Hotel:ICloneable
    {
        public string Name { get; set; }
        public string City { get; set; }

        List<Room> lista = new List<Room>();


        public void AddCameraPret(Room Camere)

        {
            lista.Add(Camere);

        }

        public void Print()
        {
            Console.WriteLine($"Hotel {Name}");
            Console.WriteLine($"City {City}");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine();
                lista[i].Print();


            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PriceNrRooms()
        {
            int sum = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                sum += lista[i].Cost.Amount;
            }
            Console.WriteLine($"Hotelul {Name} are un total de {lista.Count} camere la pretul total {sum}");
        }

        public object Clone()
        {
            Hotel hotelcopy = new Hotel();
           
            
            hotelcopy.lista = new List<Room>(this.lista);
            hotelcopy.Name = this.Name;
            hotelcopy.City = this.City;
            return hotelcopy;
        }
    }

}
