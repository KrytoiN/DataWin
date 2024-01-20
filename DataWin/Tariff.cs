using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWin
{
    public class Tariff
    {
        private string name;
        private string exp;

        public Tariff(string name, string exp)
        {
            this.name = name;
            this.exp = exp;
        }

        public string queryAdd()
        {
            return $"insert into Tariffs(nme, exp) values ('{this.name}', '{this.exp}');";
        }

        public string queryUpdate(string id)
        {
            return $"update Tariffs set nme = '{this.name}', exp = '{this.exp}' where idTariff = {id}; ";
        }

        public string[] ToStringArray()
        {
            return new string[] { this.name, this.exp };
        }
    }
}
