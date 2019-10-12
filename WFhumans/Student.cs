using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace consHuman
{
    [Serializable]
    class Student: Human
    {
        string numZachetki;
        public string NumZachetki
        {
            get { return numZachetki; }
            set { numZachetki = value; }
        }
        int numKurs;
        public int NumKurs
        {
            get { return numKurs; }
            set { numKurs = value; }
        }
        public Student() { }
        public Student(string name, string fam, int age, DateTime birthDay, string numZachetki, int numKurs):
            base(name, fam, age, birthDay)
        {
            this.numZachetki = numZachetki;
            this.numKurs = numKurs;   
        }
        public override string getFullInfo()
        {
            string info;
            info = base.getFullInfo() + String.Format("| " + this.numZachetki + " |  " + this.numKurs.ToString());
            return info;
        }
    }
}
