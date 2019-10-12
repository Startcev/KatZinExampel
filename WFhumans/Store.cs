using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace consHuman
{
    [Serializable]
    class Store
    {
        static public void safeObjects(object hum)
        {
            // Создаем поток для записи в файл
            FileStream myStream = File.Create("humData.dat");

            // Помещаем объектный граф в поток в двоичном формате
            BinaryFormatter myBinaryFormat = new BinaryFormatter();
            myBinaryFormat.Serialize(myStream, hum);
            myStream.Close();

        }
        static public object loadObjects()
        {
            // Создаем поток для записи в файл
            FileStream myStream = File.OpenRead("humData.dat");

            // Помещаем объектный граф в поток в двоичном формате
            BinaryFormatter myBinaryFormat = new BinaryFormatter();
            object obj = myBinaryFormat.Deserialize(myStream);
            myStream.Close();
            return obj;

        }
        List<Human> listHuman = new List<Human>();

        internal List<Human> ListHuman
        {
            get { return listHuman; }

        }

        public void addListHuman(Human h)
        {
            listHuman.Add(h);
        }
        public void delListHuman(Human h)
        {
            listHuman.Remove(h);
        }

        public Human searchHumanName(string name)
        {
            return listHuman.Find((t) => t.Name == name); //лямбда выражения
        }
        public void sortHumanName()
        {
            listHuman.Sort((t, t1) => t.Name.CompareTo(t1.Name)); //лямбда выражения 
        }
        public void outListHuman()
        {
            Console.WriteLine(Human.title());
            foreach (var x in listHuman)
                Console.WriteLine(x.getFullInfo());
        }
    }
}
