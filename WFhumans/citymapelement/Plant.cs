using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // завод
    class Plant : CityMapElement
    {
        // колличество выпускаемых деталей
        private int numberOfManufacturedParts;
        public int NumberOfManufacturedParts
        {
            get { return numberOfManufacturedParts; }
            set { numberOfManufacturedParts = value; }
        }
    }
}
