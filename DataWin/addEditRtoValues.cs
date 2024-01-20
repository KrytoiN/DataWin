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
    public partial class addEditRtoValues : Form
    {
        int i;
        public addEditRtoValues()
        {
            InitializeComponent();
            formEditor.setName(dataGridRtoValues, "RtoValues");
            dataBase.loadData(dataGridRtoValues);
            formEditor.defaultSettings(dataGridRtoValues);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditRtoValue.Text != "")
            {
                string value = formEditor.checkText(textEditRtoValue.Text);
                string id = dataGridRtoValues.Rows[i].Cells[0].Value.ToString();
                string idName = dataGridRtoValues.Columns[0].Name.ToString();
                string query = dataBase.queryUpdate(dataGridRtoValues.Name, value, idName, id);
                if (MessageBox.Show($"Вы уверены что хотите изменить значение \n {dataGridRtoValues.Rows[i].Cells["nme"].Value} на {value}", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValue(dataGridRtoValues, i, "nme", value);
                    }
                    else
                        MessageBox.Show("Не получилось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите ФИО владельца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddValue modal = new modalAddValue("Добавление значения RTO", "Введите значение RTO");
            if (modal.ShowDialog() == DialogResult.OK)
            {
                string value = modal.Tag as string;
                string query = dataBase.queryAdd(dataGridRtoValues.Name, value);
                string id = dataBase.addValue(query);
                if (id != "")
                    formEditor.addGridValue(dataGridRtoValues, id, value);
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridRtoValues?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridRtoValues.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridRtoValues.Name, dataGridRtoValues.Columns[0].Name, dataGridRtoValues.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridRtoValues.Rows.RemoveAt(index);
                    textEditRtoValue.Text = "";
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridRtoValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                textEditRtoValue.Text = dataGridRtoValues.Rows[i].Cells["nme"].Value.ToString();
            }
        }
    }
}
