using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace consHuman
{
        [Serializable]
    class Professor:Human
    {
        string dolgnost;
        public string Dolgnost
        {
            get { return dolgnost; }
            set { dolgnost = value; }
        }

        public Professor() { }
        public Professor(string name, string fam, int age, DateTime birthDay, string dolgnost):
            base(name, fam, age, birthDay)
        {
                this.dolgnost = dolgnost;
        }

        public new string getFullInfo()
        {
            string info;
            info = base.getFullInfo() + String.Format("| " + this.dolgnost);
            return info;
        }
    }
}
