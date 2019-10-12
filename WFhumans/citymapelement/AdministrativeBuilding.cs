using System;

namespace Kyrsach.citymapelement
{
    [Serializable]
    // административное здание
    class AdministrativeBuilding : Building
    {
        // колличество офисов
        private int numberOfOffices;
        public int NumberOfOffices
        {
            get { return numberOfOffices; }
            set { numberOfOffices = value; }
        }
    }
}