using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataWin
{
    public partial class addEditSub1 : Form
    {
        int i;
        public addEditSub1()
        {
            InitializeComponent();
            formEditor.setName(dataGridSub1, "Sub1");
            dataBase.loadData(dataGridSub1);
            formEditor.defaultSettings(dataGridSub1);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddValue modal = new modalAddValue("Добавление подразделения (ур.1)", "Введите названание подразделения (ур.1)");
            if (modal.ShowDialog() == DialogResult.OK)
            {
                string value = modal.Tag as string;
                string query = dataBase.queryAdd(dataGridSub1.Name, value);
                string id = dataBase.addValue(query);
                if (id != "")
                    formEditor.addGridValue(dataGridSub1, id, value);
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridSub1?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridSub1.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridSub1.Name, dataGridSub1.Columns[0].Name, dataGridSub1.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridSub1.Rows.RemoveAt(index);
                    textEditSub1.Text = "";
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditSub1.Text != "")
            {
                string value = formEditor.checkText(textEditSub1.Text);
                string id = dataGridSub1.Rows[i].Cells[0].Value.ToString();
                string idName = dataGridSub1.Columns[0].Name.ToString();
                string query = dataBase.queryUpdate(dataGridSub1.Name, value, idName, id);
                if (MessageBox.Show($"Вы уверены что хотите изменить значение \n {dataGridSub1.Rows[i].Cells["nme"].Value} на {value}", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValue(dataGridSub1, i, "nme", value);
                    }
                    else
                        MessageBox.Show("Не получилось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите название подразделения ур.1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridSub1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                textEditSub1.Text = dataGridSub1.Rows[i].Cells["nme"].Value.ToString();
            }
        }
    }
}
