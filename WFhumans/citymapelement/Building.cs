using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // здание
    class Building : CityMapElement
    {
        // номер здания
        protected string number;
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        // комнаты
        protected int rooms;
        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        // этажность
        protected int floors;
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
    }
}
