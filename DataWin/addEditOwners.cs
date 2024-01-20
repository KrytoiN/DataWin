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
    public partial class addEditOwners : Form
    {
        int i;
        public addEditOwners()
        {
            InitializeComponent();
            formEditor.setName(dataGridOwner, "OwnerProces");
            dataBase.loadData(dataGridOwner);
            formEditor.defaultSettings(dataGridOwner);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddValue modal = new modalAddValue("Добавление владельца процессов", "Введите ФИО владельца");
            if (modal.ShowDialog() == DialogResult.OK)
            {
                string value = modal.Tag as string;
                string query = dataBase.queryAdd(dataGridOwner.Name, value);
                string id = dataBase.addValue(query);
                if (id != "")
                    formEditor.addGridValue(dataGridOwner, id, value);
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridOwner?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridOwner.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridOwner.Name, dataGridOwner.Columns[0].Name, dataGridOwner.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridOwner.Rows.RemoveAt(index);
                    textEditOwner.Text = "";
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditOwner.Text != "")
            {
                string value = formEditor.checkText(textEditOwner.Text);
                string id = dataGridOwner.Rows[i].Cells[0].Value.ToString();
                string idName = dataGridOwner.Columns[0].Name.ToString();
                string query = dataBase.queryUpdate(dataGridOwner.Name, value, idName, id);
                if (MessageBox.Show($"Вы уверены что хотите изменить значение \n {dataGridOwner.Rows[i].Cells["nme"].Value} на {value}", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValue(dataGridOwner, i, "nme", value);
                    }
                    else
                        MessageBox.Show("Не получилось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите ФИО владельца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridOwner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                textEditOwner.Text = dataGridOwner.Rows[i].Cells["nme"].Value.ToString();
            }
        }
    }
}
