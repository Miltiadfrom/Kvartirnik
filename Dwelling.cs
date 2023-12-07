using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory
{
    public class Dwelling
    {

        private List<DwellingFloor> floors = new List<DwellingFloor>();
        public DwellingFloor this[int key]
        {
            get { return this.floors[key]; }
            set { this.floors[key] = value; }
        }

        public Dwelling(List<DwellingFloor> floors) { this.floors = floors; }

        public List<DwellingFloor> Floors { get { return this.floors; } }
        public int CountDwellingFloors { get
            {
                return this.floors.Count;
            } }

        public int CountDwellingFlats { get
            {
                int sum = 0;
                foreach (DwellingFloor floor in this.floors)
                {
                    sum += floor.CountFlats;
                }

                return sum;
            } }

        public int CountDwellingRooms
        {
            get
            { 
                int sum = 0;
                foreach (DwellingFloor floor in this.floors)
                {
                    sum += floor.CountRooms;
                }

                return sum;
                
            }
        }

        public int CountDwellingRoomsSquare
        {
            get
            {
                int sum = 0;
                foreach (DwellingFloor floor in this.floors)
                {
                    sum += floor.SumSquares;
                }

                return sum;
            }
        }


        
    }
}
