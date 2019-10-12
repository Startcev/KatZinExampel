using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // предприятие
    class Enterprise : CityMapElement
    {
        private Factory factory;
        public Factory Factory
        {
            get { return factory; }
            set { factory = value; }
        }

        private Plant plant;
        public Plant Plant
        {
            get { return plant; }
            set { plant = value; }
        }
    }
}
