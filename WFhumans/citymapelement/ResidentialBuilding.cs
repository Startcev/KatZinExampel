using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // жилое здание
    class ResidentialBuilding : Building
    {
        // колличество квартир
        private int apartments;
        public int Apartments
        {
            get { return apartments; }
            set { apartments = value; }
        }

        // колличество подъездов
        private int entrances;
        public int Entrances
        {
            get { return entrances; }
            set { entrances = value; }
        }
    }
}
