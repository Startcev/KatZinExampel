using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // фарбрика
    class Factory : CityMapElement
    {
        // колличество станков на фабрике
        private int numberOfMachines;
        public int NumberOfMachines
        {
            get { return numberOfMachines; }
            set { numberOfMachines = value; }
        }
    }
}
