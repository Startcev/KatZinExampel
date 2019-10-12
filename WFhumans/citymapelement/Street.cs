using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // улица
    class Street : CityMapElement
    {
        // название
        private string streetName;
        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        // протяженность
        private double length;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}
