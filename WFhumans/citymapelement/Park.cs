using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // парк
    class Park : CityMapElement
    {
        // название парка
        private string parkName;
        public string ParkName
        {
            get { return parkName; }
            set { parkName = value; }
        }
    }
}
