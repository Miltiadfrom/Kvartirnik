using Laboratory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class DwellingFloor
    {

        private List<Flat> flats = new List<Flat>();

        public Flat this[int key]
        {
            get { return this.flats[key]; }
            set { this.flats[key] = value; }
        }


        public DwellingFloor (List<Flat> flats) { this.flats = flats; }
        public int CountFlats {  get { return this.flats.Count; }}

        public string Flats { get {
                string flats = "";
                int count = 0;
                foreach (Flat flat in this.flats)
                {
                    count += 1;
                    flats += "Квартира " + count + ", ";
                }
                return flats;
            } }

        public int SumSquares { get
            {
                int sum = 0;

                foreach (Flat a in this.flats)
                {
                    sum += a.Square;
                }
                return sum;
            } }

        public int CountRooms
        {
            get
            {
                int sum = 0;

                foreach (Flat a in this.flats)
                {
                    sum += a.Rooms;
                }
                return sum;
            }
        }
        public Flat GetBestSpace
        {
            get
            {
                int best = 0;
                Flat best_flat = null;
                foreach (Flat a in this.flats)
                {
                    if (a.Square > best) {
                        best = a.Square;
                        best_flat = a;
                    };
                }

                return best_flat;
            }
        }
        public void Get_Flat_object(Flat obj) //метод получения объекта
        {
            string number_of_flat = "";
            int number = 0;
            Console.WriteLine("введите индекс(номер от 0) квартиры: ");
            number_of_flat = Console.ReadLine();
            if (Int32.TryParse(number_of_flat, out number)) {
                Console.WriteLine(Flats[number]);
            }
            else
            {
                throw new Exception("Ошибка! Некорректно введёные данные");
            }
        }
        public void Change_Flat_object(Flat obj) //метод изменения квартиры хз как
        {
            string number_of_flat = "";
            int number = 0;
            Console.WriteLine("введите индекс(номер от 0) квартиры: ");
            number_of_flat = Console.ReadLine();
            if (Int32.TryParse(number_of_flat, out number))
            {
                Console.WriteLine(Flats[number]);
                
            }
            else
            {
                throw new Exception("Ошибка! Некорректно введёные данные");
            }
        }
        public void Change_count_Flat_object(Flat obj) //метод добавления квартиры
        {
            string number_of_flat = "";
            int number = 0;
            Console.WriteLine("введите индекс(номер от 0) квартиры: ");
            number_of_flat = Console.ReadLine();
            if (Int32.TryParse(number_of_flat, out number))
            {
                flats.Add(obj);

            }
            else
            {
                throw new Exception("Ошибка! Некорректно введёные данные");
            }
        }
        public void Change_size_Flat_object(Flat obj) //метод удаления квартиры
        {
            string number_of_flat = "";
            int number = 0;
            Console.WriteLine("введите индекс(номер от 0) квартиры: ");
            number_of_flat = Console.ReadLine();
            if (Int32.TryParse(number_of_flat, out number))
            {
                flats.Remove(obj);

            }
            else
            {
                throw new Exception("Ошибка! Некорректно введёные данные");
            }
        }
    }
}
