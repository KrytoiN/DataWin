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
    public partial class addEditFreq : Form
    {
        int i;
        public addEditFreq()
        {
            InitializeComponent();
            formEditor.setName(dataGridFreq, "FreqProcess");
            dataBase.loadData(dataGridFreq);
            formEditor.defaultSettings(dataGridFreq);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddValue modal = new modalAddValue("Добавление частоты процесса", "Введите частоту процесса");
            if (modal.ShowDialog() == DialogResult.OK)
            {
                string value = modal.Tag as string;
                string query = dataBase.queryAdd(dataGridFreq.Name, value);
                string id = dataBase.addValue(query);
                if (id != "")
                    formEditor.addGridValue(dataGridFreq, id, value);
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridFreq?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridFreq.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridFreq.Name, dataGridFreq.Columns[0].Name, dataGridFreq.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridFreq.Rows.RemoveAt(index);
                    textEditFreq.Text = "";
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridFreq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                textEditFreq.Text = dataGridFreq.Rows[i].Cells["nme"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditFreq.Text != "")
            {
                string value = formEditor.checkText(textEditFreq.Text);
                string id = dataGridFreq.Rows[i].Cells[0].Value.ToString();
                string idName = dataGridFreq.Columns[0].Name.ToString();
                string query = dataBase.queryUpdate(dataGridFreq.Name, value, idName, id);
                if (MessageBox.Show($"Вы уверены что хотите изменить значение \n {dataGridFreq.Rows[i].Cells["nme"].Value} на {value}", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValue(dataGridFreq, i, "nme", value);
                    }
                    else
                        MessageBox.Show("Не получилось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите частоту процесса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
