using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // аэропорт
    class Airport : CityMapElement
    {
        // название
        private string airportName;
        public string AirportName
        {
            get { return airportName; }
            set { airportName = value; }
        }

        // класс аэропорта
        private string airClass;
        public string AirClass
        {
            get { return airClass; }
            set { airClass = value; }
        }

        // кодовый номер
        private string _ICAO;
        public string ICAO
        {
            get { return _ICAO; }
            set { _ICAO = value; }
        }
    }
}
