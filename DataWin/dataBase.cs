using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWin
{
    public static class dataBase
    {
        private static string connect;
        private static MySqlConnection connection;
        private static string dataName;

        public static bool Connect()
        {
            try
            {
                connect = "server=localhost;user=root;database=bank;password=Ifhfvsuf2001;";
                connection = new MySqlConnection(connect);
                connection.Open();
                dataName = "bank";
                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool Connect(string data, string pass)
        {
            try
            {
                connect = $"server=localhost;user=root;database={data};password={pass};";
                connection = new MySqlConnection(connect);
                connection.Open();
                dataName = data;
                MessageBox.Show("Соединение прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Введены неверные данные, попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string[] loadTableNames(DataGridView data)
        {
            string query = $"show columns from {data.Name};";
            DataTable table = loadTable(query);
            string[] tableNames = new string[table.Rows.Count];
            for (int i = 0; i < tableNames.Length; ++i)
                tableNames[i] = table.Rows[i][0].ToString();
            return tableNames;
        }

        public static void loadData(DataGridView data)
        {
            string queryGrid = "";
            string queryData = "";
            switch (data.Name)
            {
                case "Sub1":
                    {
                        queryGrid = "select idNme as id, nme as 'Подразделение (ур. 1)' from Sub1;";
                        queryData = "select * from Sub1;";
                        break;
                    }
                case "Sub2":
                    {
                        queryGrid = "select sub2.idNme2 as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)' from sub2 " +
                                    "inner join sub1 on sub2.idNme = sub1.idNme;";
                        queryData = "select sub2.idNme2, sub1.idNme, sub2.nme from sub2 " +
                                    "inner join sub1 on sub2.idNme = sub1.idNme;";
                        break;
                    }
                case "Sub3":
                    {
                        queryGrid = "select sub3.idNme3 as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)', sub3.nme as 'Подразделение (ур. 3)' from sub3 " +
                                    "inner join sub2 on sub3.idNme2 = sub2.idNme2 " +
                                    "inner join sub1 on sub2.idNme = sub1.idNme;";
                        queryData = "select sub3.idNme3, sub1.idNme, sub2.idNme2, sub3.nme from sub3 " +
                                    "inner join sub2 on sub3.idNme2 = sub2.idNme2 " +
                                    "inner join sub1 on sub2.idNme = sub1.idNme;";
                        break;
                    }
                case "KindActivity":
                    {
                        queryGrid = "select idActiv as id, nme as 'Вид деятельности' from KindActivity;";
                        queryData = "select * from KindActivity";
                        break;
                    }
                case "FreqProcess":
                    {
                        queryGrid = "select idFreq as id, nme as 'Частоты процессов' from FreqProcess;";
                        queryData = "select * from FreqProcess;";
                        break;
                    }
                case "RtoValues":
                    {
                        queryGrid = "select idRto as id, nme as 'Значение RTO' from RtoValues;";
                        queryData = "select * from RtoValues;";
                        break;
                    }
                case "OwnerProces":
                    {
                        queryGrid = "select idOwner as id, nme as 'ФИО владельца' from OwnerProces;";
                        queryData = "select * from OwnerProces;";
                        break;
                    }
                case "Tariffs":
                    {
                        queryGrid = "select idTariff as id, nme as 'Название тарифа', exp as 'Пояснение' from Tariffs";
                        queryData = "select * from Tariffs";
                        break;
                    }
                case "Proces":
                    {
                        queryGrid = "select proces.idProcess as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)', sub3.nme as 'Подразделение (ур. 3)', FreqProcess.nme as 'Частота процесса', KindActivity.nme as 'Вид деятельности', OwnerProces.nme as 'Владелец процесса', " +
                                    "RtoValues.nme as 'RTO', proces.rtoPrev as 'Предыдущее RTO', Tariffs.nme as 'Тариф', Proces.nme as 'Название процесса' from proces " +
                                    "inner join FreqProcess on proces.idFreq = FreqProcess.idFreq " +
                                    "inner join KindActivity on proces.idActiv = KindActivity.idActiv " +
                                    "inner join OwnerProces on proces.idOwner = OwnerProces.idOwner " +
                                    "inner join RtoValues on proces.idRto = RtoValues.idRto " +
                                    "inner join Tariffs on proces.idTariff = Tariffs.idTariff " +
                                    "inner join sub3 on proces.idNme3 = sub3.idNme3 " +
                                    "inner join sub2 on sub3.idNme2 = sub2.idNme2 " +
                                    "inner join sub1 on sub2.idNme = sub1.idNme;";
                        queryData = "select proces.idProcess, sub1.idNme, sub2.idNme2, sub3.idNme3, FreqProcess.idFreq, KindActivity.idActiv, OwnerProces.idOwner, RtoValues.idRto, proces.rtoPrev, Tariffs.idTariff, Proces.nme from proces " +
                                    "inner join FreqProcess on proces.idFreq = FreqProcess.idFreq " +
                                    "inner join KindActivity on proces.idActiv = KindActivity.idActiv " +
                                    "inner join OwnerProces on proces.idOwner = OwnerProces.idOwner " +
                                    "inner join RtoValues on proces.idRto = RtoValues.idRto " +
                                    "inner join Tariffs on proces.idTariff = Tariffs.idTariff " +
                                    "inner join sub3 on proces.idNme3 = sub3.idNme3 " +
                                    "inner join sub2 on sub3.idNme2 = sub2.idNme2 " +
                                    "inner join sub1 on sub2.idNme = sub1.idNme;";
                        break;
                    }
                case "Rto":
                    {
                        queryGrid = "select rto.idRto as id, sub1.nme as 'Подразделение (ур. 1)', sub2.nme as 'Подразделение (ур. 2)', sub3.nme as 'Подразделение (ур. 3)', Proces.nme as 'Бизнес-процесс', Rto.timing2Hours as '2 часа', Rto.timing4Hours as '4 часа', Rto.timing8Hours as '8 часов', Rto.timing24Hours as '24 часа', Rto.timing5Days as '5 дней', Rto.timing30Days as '30 дней', Rto.impactDowntime as 'Влияние от простоя', Rto.rto as 'Значение RTO', Rto.rtoPrev as 'Предыдущее значение RTO' from rto inner join proces on rto.idProcess = proces.idProcess inner join sub3 on proces.idNme3 = sub3.idNme3 inner join sub2 on sub3.idNme2 = sub2.idNme2 inner join sub1 on sub2.idNme = sub1.idNme;";
                        queryData = "select rto.idRto, sub1.idNme, sub2.idNme2, sub3.idNme3, Proces.idProcess, Rto.timing2Hours, Rto.timing4Hours, Rto.timing8Hours, Rto.timing24Hours, Rto.timing5Days, Rto.timing30Days, Rto.impactDowntime, Rto.rto, Rto.rtoPrev from rto inner join proces on rto.idProcess = proces.idProcess inner join sub3 on proces.idNme3 = sub3.idNme3 inner join sub2 on sub3.idNme2 = sub2.idNme2 inner join sub1 on sub2.idNme = sub1.idNme;";
                        break;
                    }
                case "Addictions":
                    {
                        queryGrid = "select idAdd as id, nme as 'Степень зависимости' from Addictions;";
                        queryData = "select * from Addictions;";
                        break;
                    }

            }
            executeQueryLoad(queryGrid, data);
            loadTags(queryData, data);
        }

        public static string queryAdd(string dataName, string value)
        {
            return $"insert into {dataName}(nme) values ('{value}');";
        }

        /*public static string queryAdd(string dataName, string[] tableNames, string[] values)
        {
            string names = string.Join(",", tableNames.Skip(1));
            string[] sortValues = values.Select(n => int.TryParse(n, out _) ? n : ("\"" + n + "\"")).ToArray();
            string query = $"insert into {dataName}({names}) values ({string.Join(",", sortValues)});";
            return query;
        }

        public static string queryUpdate(string dataName, string[] tableNames, string[] values, string id)
        {
            string query = $"update {dataName} set ";
            string[] sortValues = values.Select(n => int.TryParse(n, out _) ? n : ("\"" + n + "\"")).ToArray();
            string[] a = new string[tableNames.Length - 1];
            for(int i = 1; i < tableNames.Length; ++i)
            {
                a[i - 1] = $"{tableNames[i]} = {sortValues[i - 1]}";
            }
            query += string.Join(",", a) + $" where {tableNames[0]} = {id};";
            return query;
        } */

        public static string queryUpdate(string dataName, string value, string idName, string id)
        {
            return $"update {dataName} set nme = '{value}' where {idName} = {id}; ";
        }

        private static DataTable loadTable(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static string addValue(string query)
        {
            try
            {
                string queryID = "select last_insert_id()";
                query += queryID;
                string k = query;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string id = cmd.ExecuteScalar().ToString();
                return id;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static void loadCombo(string query, string id, string name, ComboBox combo)
        {
            /*MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table); */
            DataTable table = loadTable(query);
            if (table.Rows.Count > 0)
            {
                combo.DataSource = table;
                combo.DisplayMember = name;
                combo.ValueMember = id;
            }
            else
            {
                DataRow dt = table.NewRow();
                dt[id] = "-1";
                dt[name] = "Ничего нет";
                table.Rows.InsertAt(dt, 0);
                combo.DataSource = table;
                combo.DisplayMember = name;
                combo.ValueMember = id;
            }
        }

        public static bool delValue(string tableName, string nameID, string id)
        {
            try
            {
                string query = "delete from " + tableName + " where " + nameID + " = " + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }
        }

        public static bool updateValue(string query)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                return false;
            }
        }

        private static void executeQueryLoad(string query, DataGridView data)
        {
            try
            {
                DataTable table = loadTable(query);
                data.ColumnCount = table.Columns.Count;
                for (int i = 0; i < data.Columns.Count; ++i)
                    data.Columns[i].HeaderText = table.Columns[i].ColumnName;
                for (int i = 0; i < table.Rows.Count; ++i)
                {
                    data.Rows.Add();
                    for (int j = 0; j < data.Columns.Count; ++j)
                    {
                        data.Rows[i].Cells[j].Value = table.Rows[i][j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void loadTags(string query, DataGridView data)
        {
            try
            {
                DataTable table = loadTable(query);
                for (int j = 0; j < data.ColumnCount; ++j)
                {
                    data.Columns[j].Name = table.Columns[j].ColumnName;
                    for (int i = 0; i < data.RowCount - 1; ++i)
                    {
                        data.Rows[i].Cells[j].Tag = table.Rows[i][j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void createTables()
        {
            string query = $@"
            use {dataName};

            create table if not exists Sub1
            (
	            idNme int auto_increment not null primary key comment 'Номер подразделения 1 уровня',
                nme varchar(80) not null comment 'Название подразделения 1 уровня',
                CONSTRAINT Sub1_unique UNIQUE (nme)
            );

            create table if not exists Sub2
            (
	            idNme2 int auto_increment not null primary key comment 'Номер подразделения 2 уровня',
                idNme int comment 'Номер подразделения 1',
                nme varchar(80) not null comment 'Название подразделения 2',
	            foreign key (idNme) references Sub1(idNme) on delete cascade on update cascade,
                CONSTRAINT idSub2_unique UNIQUE (idNme, nme)
            );

            create table if not exists Sub3
            (
	            idNme3 int auto_increment not null primary key comment 'Номер подразделения 3 уровня',
                idNme2 int not null comment 'Номер подразделения 2 уровня',
                nme varchar(80) not null comment 'Название подразделения 3 уровня',
	            foreign key (idNme2) references Sub2(idNme2) on delete cascade on update cascade,
                CONSTRAINT idSub3_unique UNIQUE (idNme2, nme)
            );

            create table if not exists FreqProcess
            (
	            idFreq int auto_increment not null primary key comment 'Номер частоты реализации процесса',
                nme varchar(80) not null comment 'Название частоты реализации процесса'
            );

            create table if not exists KindActivity
            (
	            idActiv int auto_increment not null primary key comment 'Номер вида деятельности',
                nme varchar(80) not null comment 'Название вида деятельности'
            );

            create table if not exists Proces
            (
	            idProcess int auto_increment not null primary key comment 'Номер процесса',
                idNme3 int comment 'Номер подразделения 3 уровня',
                idFreq int comment 'Номер частоты реализации процесса',
                idActiv int comment 'Номер вида деятельности',
                nme varchar(80) not null comment 'Название процесса',
                foreign key (idNme3) references Sub3(idNme3) on delete cascade on update cascade,
                foreign key (idFreq) references FreqProcess(idFreq) on delete cascade on update cascade,
                foreign key (idActiv) references KindActivity(idActiv) on delete cascade on update cascade,
                CONSTRAINT Proces_unique UNIQUE (nme)
            );";

            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }



    }
}
