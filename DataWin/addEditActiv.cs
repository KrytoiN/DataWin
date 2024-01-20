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
    public partial class addEditActiv : Form
    {
        int i;
        public addEditActiv()
        {
            InitializeComponent();
            formEditor.setName(dataGridActiv, "KindActivity");
            dataBase.loadData(dataGridActiv);
            formEditor.defaultSettings(dataGridActiv);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddValue modal = new modalAddValue("Добавление вида деятельности", "Введите название вида деятельности");
            if (modal.ShowDialog() == DialogResult.OK)
            {
                string value = modal.Tag as string;
                string query = dataBase.queryAdd(dataGridActiv.Name, value);
                string id = dataBase.addValue(query);
                if (id != "")
                    formEditor.addGridValue(dataGridActiv, id, value);
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridActiv?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridActiv.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridActiv.Name, dataGridActiv.Columns[0].Name, dataGridActiv.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridActiv.Rows.RemoveAt(index);
                    textEditActiv.Text = "";
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridActiv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                textEditActiv.Text = dataGridActiv.Rows[i].Cells["nme"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditActiv.Text != "")
            {
                string value = formEditor.checkText(textEditActiv.Text);
                string id = dataGridActiv.Rows[i].Cells[0].Value.ToString();
                string idName = dataGridActiv.Columns[0].Name.ToString();
                string query = dataBase.queryUpdate(dataGridActiv.Name, value, idName, id);
                if (MessageBox.Show($"Вы уверены что хотите изменить значение \n {dataGridActiv.Rows[i].Cells["nme"].Value} на {value}", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValue(dataGridActiv, i, "nme", value);
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
