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
    public partial class addEditTariffs : Form
    {
        int i;
        public addEditTariffs()
        {
            InitializeComponent();
            formEditor.setName(dataGridTariffs, "Tariffs");
            dataBase.loadData(dataGridTariffs);
            formEditor.defaultSettings(dataGridTariffs);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddTariff modal = new modalAddTariff();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                Tariff value = modal.Tag as Tariff;
                string query = value.queryAdd();
                string id = dataBase.addValue(query);
                if (id != "")
                {
                    int index = formEditor.addGridValues(dataGridTariffs, id, value.ToStringArray());
                    formEditor.addGridTags(dataGridTariffs, index, value.ToStringArray());
                }
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridTariffs?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridTariffs.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridTariffs.Name, dataGridTariffs.Columns[0].Name, dataGridTariffs.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridTariffs.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditTarif.Text != "")
            {
                Tariff tarif = new Tariff(formEditor.checkText(textEditTarif.Text), formEditor.checkText(textEditExp.Text));
                string id = dataGridTariffs.Rows[i].Cells[0].Value.ToString();
                string query = tarif.queryUpdate(id);
                if (MessageBox.Show(formEditor.formMessage(dataGridTariffs, i, tarif.ToStringArray()), "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValues(dataGridTariffs, i, tarif.ToStringArray());
                        formEditor.addGridTags(dataGridTariffs, i, tarif.ToStringArray());
                    }
                    else
                        MessageBox.Show("Не получилось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите название подразделения ур.2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridRtoValues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                textEditTarif.Text = dataGridTariffs.Rows[i].Cells["nme"].Value.ToString();
                textEditExp.Text = dataGridTariffs.Rows[i].Cells["exp"].Value.ToString();
            }
        }

    }
}
