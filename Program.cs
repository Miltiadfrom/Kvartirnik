using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Flat> flats = new List<Flat>();
            string proverka;
            do
            {
                Console.WriteLine("Желаете добавить ещё квартиру? y/n");
                proverka = Console.ReadLine();
                if (proverka != "n")
                {
                    int resultSquare;
                    int resultRooms;
                    Console.WriteLine("площадь = "); 
                    string square = Console.ReadLine();
                    Console.WriteLine("Количество комнат квартиры = ");
                    string rooms = Console.ReadLine();
                    if (Int32.TryParse(square, out resultSquare) && Int32.TryParse(rooms, out resultRooms)) {
                        flats.Add(new Flat(resultSquare, resultRooms));
                    }
                    else
                    {
                        flats.Add(new Flat());
                    }
                }

            }
            while (proverka != "n");

            var floor = new DwellingFloor(flats);

            Console.WriteLine($"{floor.CountRooms}");
            Console.WriteLine($"{floor.Flats}");
            List<DwellingFloor> floors = new List<DwellingFloor>();
            floors.Add(floor);

            var home = new Dwelling(floors);

        }
    }
}