using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // элементы карты города
    class CityMapElement
    {
        // широта
        protected double latitude;

        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        // долгота
        protected double longitude;
        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        // площадь
        protected double area;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }
    }
}
