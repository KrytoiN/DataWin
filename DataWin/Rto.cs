using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWin
{
    public class Rto
    {
        private string idNme;
        private string idNmeGrid;
        private string idNme2;
        private string idNme2Grid;
        private string idNme3;
        private string idNme3Grid;
        private string idProcess;
        private string idProcessGrid;
        private string timing2Hours;
        private string timing4Hours;
        private string timing8Hours;
        private string timing24Hours;
        private string timing5Days;
        private string timing30Days;
        private string impact;
        private string rto;
        private string rtoPrev;

        public Rto(string idNme, string idNmeGrid, string idNme2, string idNme2Grid, string idNme3, string idNme3Grid, string idProcess, string idProcessGrid,
                string timing2Hours, string timing4Hours, string timing8Hours, string timing24Hours, string timing5Days, string timing30Days, string impact,
                string rto, string rtoPrev)
        {
            this.idNme = idNme;
            this.idNmeGrid = idNmeGrid;
            this.idNme2 = idNme2;
            this.idNme2Grid = idNme2Grid;
            this.idNme3 = idNme3;
            this.idNme3Grid = idNme3Grid;
            this.idProcess = idProcess;
            this.idProcessGrid = idProcessGrid;
            this.timing2Hours = timing2Hours;
            this.timing4Hours = timing4Hours;
            this.timing8Hours = timing8Hours;
            this.timing24Hours = timing24Hours;
            this.timing5Days = timing5Days;
            this.timing30Days = timing30Days;
            this.impact = impact;
            this.rto = rto;
            this.rtoPrev = rtoPrev;
        }

        public string queryAdd()
        {
            return $"insert into Rto(idProcess, timing2Hours, timing4Hours, timing8Hours, timing24Hours, timing5Days, timing30Days, impactDowntime, rto, rtoPrev) values ({this.idProcess}, " +
                $"'{this.timing2Hours}', '{this.timing4Hours}', '{this.timing8Hours}', '{this.timing24Hours}', '{this.timing5Days}', '{this.timing30Days}', '{this.impact}', " +
                $" '{this.rto}', '{this.rtoPrev}'); ";
        }

        public string queryUpdate(string id)
        {
            return $"update Rto set idProcess = {this.idProcess}, timing2Hours = '{this.timing2Hours}', timing4Hours = '{this.timing4Hours}', timing8Hours = '{this.timing8Hours}', timing24Hours = '{this.timing24Hours}', " +
                $" timing5Days = '{this.timing5Days}', timing30Days = '{this.timing30Days}', impactDowntime = '{this.impact}', " +
                $"rto = '{this.rto}', rtoPrev = '{this.rtoPrev}' where idRto = {id}";
        }

        public string[] ToStringArray()
        {
            return new string[] { this.idNmeGrid, this.idNme2Grid, this.idNme3Grid, this.idProcessGrid, this.timing2Hours, 
                this.timing4Hours, this.timing8Hours, this.timing24Hours, this.timing5Days, this.timing30Days, this.impact, this.rto, this.rtoPrev };
        }

        public string[] ToStringTags()
        {
            return new string[] { this.idNme, this.idNme2, this.idNme3, this.idProcess, this.timing2Hours,
                this.timing4Hours, this.timing8Hours, this.timing24Hours, this.timing5Days, this.timing30Days, this.impact, this.rto, this.rtoPrev };
        }
    }
}
