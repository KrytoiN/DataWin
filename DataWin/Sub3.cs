using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWin
{
    public class Sub3
    {
        private string idNme;
        private string idNmeGrid;
        private string idNme2;
        private string idNme2Grid;
        private string name;

        public string IdNmeGrid { get { return idNmeGrid; } set { idNmeGrid = value; } }
        public string IdNme2Grid { get { return idNme2Grid; } set { idNme2Grid = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Sub3(string idNme, string idNmeGrid, string idNme2, string idNme2Grid, string name)
        {
            this.idNme = idNme;
            this.idNmeGrid = idNmeGrid;
            this.idNme2 = idNme2;
            this.idNme2Grid = idNme2Grid;
            this.name = name;
        }

        public string queryAdd()
        {
            return $"insert into Sub3(idNme2, nme) values ({this.idNme2}, '{this.name}'); ";
        }

        public string queryUpdate(string id)
        {
            return $"update Sub3 set idNme2 = {this.idNme2}, nme = '{this.name}' where idNme3 = {id}; ";
        }

        public string[] ToStringArray()
        {
            return new string[] { this.idNmeGrid, this.idNme2Grid, this.name };
        }

        public string[] ToStringTags()
        {
            return new string[] { this.idNme, this.idNme2, this.name };
        }
    }
}
