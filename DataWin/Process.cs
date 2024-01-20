using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWin
{
    public class Process
    {
        private string idNme;
        private string idNmeGrid;
        private string idNme2;
        private string idNme2Grid;
        private string idNme3;
        private string idNme3Grid;
        private string idFreq;
        private string idFreqGrid;
        private string idActiv;
        private string idActivGrid;
        private string idOwner;
        private string idOwnerGrid;
        private string idRto;
        private string idRtoGrid;
        private string rtoPrev;
        private string idTariff;
        private string idTariffGrid;
        private string name;

        public string IdNmeGrid { get { return idNmeGrid; } set { idNmeGrid = value; } }
        public string IdNme2Grid { get { return idNme2Grid; } set { idNme2Grid = value; } }
        public string IdNme3Grid { get { return idNme2Grid; } set { idNme2Grid = value; } }
        public string IdFreqGrid { get { return idFreqGrid; } set { idFreqGrid = value; } }
        public string IdActivGrid { get { return idActivGrid; } set { idActivGrid = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Process(string idNme, string idNmeGrid, string idNme2, string idNme2Grid, string idNme3, string idNme3Grid, string idFreq, string idFreqGrid, string idActiv, string idActivGrid,
            string idOwner, string idOwnerGrid, string idRto, string idRtoGrid, string rtoPrev, string idTariff, string idTariffGrid, string name)
        {
            this.idNme = idNme;
            this.idNmeGrid = idNmeGrid;
            this.idNme2 = idNme2;
            this.idNme2Grid = idNme2Grid;
            this.idNme3 = idNme3;
            this.idNme3Grid = idNme3Grid;
            this.idFreq = idFreq;
            this.idFreqGrid = idFreqGrid;
            this.idActiv = idActiv;
            this.idActivGrid = idActivGrid;
            this.idOwner = idOwner;
            this.idOwnerGrid = idOwnerGrid;
            this.idRto = idRto;
            this.idRtoGrid = idRtoGrid;
            this.rtoPrev = rtoPrev;
            this.idTariff = idTariff;
            this.idTariffGrid = idTariffGrid;
            this.name = name;
        }

        public string queryAdd()
        {
            return $"insert into Proces(idNme3, idFreq, idActiv, idOwner, idRto, rtoPrev, idTariff, nme) values ({this.idNme3}, {this.idFreq}, {this.idActiv}, {this.idOwner}, {this.idRto}, '{this.rtoPrev}', {this.idTariff}, '{this.name}'); ";
        }

        public string queryUpdate(string id)
        {
            return $"update Proces set idNme3 = {this.idNme3}, idFreq = {this.idFreq}, idActiv = {this.idActiv}, idOwner = {this.idOwner}, idRto = {this.idRto}, rtoPrev = '{this.rtoPrev}', idTariff = {this.idTariff}, nme = '{this.name}' where idProcess = {id}";
        }

        public string[] ToStringArray()
        {
            return new string[] { this.idNmeGrid, this.idNme2Grid, this.idNme3Grid, this.idFreqGrid, this.idActivGrid, this.idOwnerGrid, this.idRtoGrid, this.rtoPrev, this.idTariffGrid, this.name };
        }

        public string[] ToStringTags()
        {
            return new string[] { this.idNme, this.idNme2, this.idNme3, this.idFreq, this.idActiv, this.idOwner, this.idRto, this.rtoPrev, this.idTariff, this.name};
        }
    }
}
