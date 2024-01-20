using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWin
{
    public class Sub2
    {
        private string idNme;
        private string idNmeGrid;
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public string IdNme { get { return idNme; } set { idNme = value; } }
        public string IdNmeGrid { get { return idNmeGrid; } set { idNmeGrid = value; } }

        public Sub2(string idNme, string idNmeGrid, string Name)
        {
            this.idNme = idNme;
            this.name = Name;
            this.idNmeGrid = idNmeGrid;
        }

        public string queryAdd()
        {
            return $"insert into Sub2(idNme, nme) values ({this.idNme}, '{this.name}'); ";
        }

        public string queryUpdate(string id)
        {
            return $"update Sub2 set idNme = {this.idNme}, nme = '{this.name}' where idNme2 = {id}; ";
        }

        public string[] ToStringArray()
        {
            return new string[] { this.idNmeGrid, this.name };
        }

        public string[] ToStringTags()
        {
            return new string[] { this.idNme, this.name };
        }
    }
}
