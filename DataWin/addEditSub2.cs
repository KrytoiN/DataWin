using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataWin
{
    public partial class addEditSub2 : Form
    {
        int i;
        public addEditSub2()
        {
            InitializeComponent();
            formEditor.setName(dataGridSub2, "Sub2");
            dataBase.loadData(dataGridSub2);
            formEditor.defaultSettings(dataGridSub2);
            formEditor.defaultSettingsCombo(comboEditSub1);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddSub2 modal = new modalAddSub2();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                Sub2 value = modal.Tag as Sub2;
                string query = value.queryAdd();
                string id = dataBase.addValue(query);
                if (id != "")
                {
                    int index = formEditor.addGridValues(dataGridSub2, id, value.ToStringArray());
                    formEditor.addGridTags(dataGridSub2, index, value.ToStringTags());
                }
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridSub2?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridSub2.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridSub2.Name, dataGridSub2.Columns[0].Name, dataGridSub2.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridSub2.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridSub2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                string idSub1 = dataGridSub2.Rows[i].Cells["idNme"].Tag.ToString();
                string nameSub2 = dataGridSub2.Rows[i].Cells["nme"].Tag.ToString();
                dataBase.loadCombo($"select * from Sub1", "idNme", "nme", comboEditSub1);
                comboEditSub1.SelectedValue = idSub1;
                textEditSub2.Text = nameSub2;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditSub2.Text != "")
            {
                Sub2 sub2 = new Sub2(comboEditSub1.SelectedValue.ToString(), comboEditSub1.Text, formEditor.checkText(textEditSub2.Text));
                string id = dataGridSub2.Rows[i].Cells[0].Value.ToString();
                string query = sub2.queryUpdate(id);
                if (MessageBox.Show(formEditor.formMessage(dataGridSub2, i, sub2.ToStringArray()), "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValues(dataGridSub2, i, sub2.ToStringArray());
                        formEditor.addGridTags(dataGridSub2, i, sub2.ToStringTags());
                    }
                    else
                        MessageBox.Show("Не получилось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите название подразделения ур.2", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
