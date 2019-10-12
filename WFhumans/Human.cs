using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace consHuman
{
        [Serializable]
    class Human
    {
     
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        string fam;
        public string Fam
        {
            get { return fam; }
            set { fam = value; }
        }
       
        int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
       
        DateTime birthDay;
        public DateTime BirthDay
        {
            get { return birthDay; }
            set { birthDay = value; }
        }
        public Human() { }
        string name;
        public Human(string name, string fam, int age, DateTime birthDay)
        {
            this.name = name;
            this.fam = fam;
            this.age = age;
            this.birthDay = birthDay;
        }

        public virtual string getFullInfo() {
            string info;
            info = String.Format("|  " + name + " |  "
                + fam + " |  " + age.ToString() + 
                " | "+birthDay.ToShortDateString());
            return info;
        }
        public static string title()
        {
            string info;
            info = String.Format("|  name |  fam    | age | birthDay ");
                          info += "\n __________________________________";
            return info;
        }
    }
}
