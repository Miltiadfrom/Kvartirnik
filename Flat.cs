using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Flat
    {
        public int square = 50; // площадь
        public int rooms_num = 2; // Количество комнат
        public Flat(int square = 50, int rooms = 2)
        {
            if (square <= 0 || rooms <= 0)
            {
                throw new Exception("Ошибка");
            } else
            {
                this.square = square;
                this.rooms_num = rooms;
            }
        }

        public int Square
        {
            get { return this.square; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Площадь квартиры не может быть меньше или равно 0");
                }
                this.square = value;
            }
        }

        public int Rooms
        {
            get => this.rooms_num;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Комнат в  квартире не может быть меньше или равно 0");
                }
                this.rooms_num = value;
            }
        }

    }
}
