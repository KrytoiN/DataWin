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
    public partial class addEditSub3 : Form
    {
        int i;
        public addEditSub3()
        {
            InitializeComponent();
            formEditor.setName(dataGridSub3, "Sub3");
            dataBase.loadData(dataGridSub3);
            formEditor.defaultSettings(dataGridSub3);
            formEditor.defaultSettingsCombo(comboEditSub1);
            formEditor.defaultSettingsCombo(comboEditSub2);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddSub3 modal = new modalAddSub3();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                Sub3 value = modal.Tag as Sub3;
                string query = value.queryAdd();
                string id = dataBase.addValue(query);
                if (id != "")
                {
                    int index = formEditor.addGridValues(dataGridSub3, id, value.ToStringArray());
                    formEditor.addGridTags(dataGridSub3, index, value.ToStringTags());
                }
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridSub3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                string idSub1 = dataGridSub3.Rows[i].Cells["idNme"].Tag.ToString();
                string idSub2 = dataGridSub3.Rows[i].Cells["idNme2"].Tag.ToString();
                string nameSub3 = dataGridSub3.Rows[i].Cells["nme"].Tag.ToString();
                dataBase.loadCombo($"select * from Sub1", "idNme", "nme", comboEditSub1);
                comboEditSub1.SelectedValue = idSub1;
                dataBase.loadCombo($"select idNme2, nme from Sub2 where idNme = {idSub1}", "idNme2", "nme", comboEditSub2);
                comboEditSub2.SelectedValue = idSub2;
                textEditSub3.Text = nameSub3;
            }
        }

        private void comboEditSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)comboEditSub1.SelectedItem;
            int value = Convert.ToInt32(selectedRow.Row[0]);
            string query = "select idNme2, nme from Sub2 where idNme = " + value.ToString();
            dataBase.loadCombo(query, "idNme2", "nme", comboEditSub2);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditSub3.Text != "" && comboEditSub2.SelectedValue.ToString() != "-1")
            {
                Sub3 sub3 = new Sub3(comboEditSub1.SelectedValue.ToString(), comboEditSub1.Text, comboEditSub2.SelectedValue.ToString(), comboEditSub2.Text, formEditor.checkText(textEditSub3.Text));
                string id = dataGridSub3.Rows[i].Cells[0].Value.ToString();
                string query = sub3.queryUpdate(id);
                if (MessageBox.Show(formEditor.formMessage(dataGridSub3, i, sub3.ToStringArray()), "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValues(dataGridSub3, i, sub3.ToStringArray());
                        formEditor.addGridTags(dataGridSub3, i, sub3.ToStringTags());
                    }
                    else
                        MessageBox.Show("Не удалось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите название подразделения ур.3 или привяжите к выбранному Подразделению ур.1 - Подразделение ур.2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridSub3?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridSub3.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridSub3.Name, dataGridSub3.Columns[0].Name, dataGridSub3.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridSub3.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
