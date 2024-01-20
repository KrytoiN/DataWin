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
    public partial class addEditRto : Form
    {
        int i;
        public addEditRto()
        {
            InitializeComponent();
            formEditor.setName(dataGridRto, "Rto");
            dataBase.loadData(dataGridRto);
            formEditor.defaultSettings(dataGridRto);
            formEditor.defaultSettingsCombo(comboEditSub1);
            formEditor.defaultSettingsCombo(comboEditSub2);
            formEditor.defaultSettingsCombo(comboEditSub3);
            //gridEditor.defaultSettingsCombo(comboEditActiv);
            //gridEditor.defaultSettingsCombo(comboEditFreq);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddRto modal = new modalAddRto();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                Rto value = modal.Tag as Rto;
                string query = value.queryAdd();
                string id = dataBase.addValue(query);
                if (id != "")
                {
                    int index = formEditor.addGridValues(dataGridRto, id, value.ToStringArray());
                    formEditor.addGridTags(dataGridRto, index, value.ToStringTags());
                }
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridRto?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridRto.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridRto.Name, dataGridRto.Columns[0].Name, dataGridRto.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridRto.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridRto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                string idSub1 = dataGridRto.Rows[i].Cells["idNme"].Tag.ToString();
                string idSub2 = dataGridRto.Rows[i].Cells["idNme2"].Tag.ToString();
                string idSub3 = dataGridRto.Rows[i].Cells["idNme3"].Tag.ToString();
                string rto = dataGridRto.Rows[i].Cells["rto"].Tag.ToString();
                string rtoPrev = dataGridRto.Rows[i].Cells["rtoPrev"].Tag.ToString();
                dataBase.loadCombo($"select * from Sub1", "idNme", "nme", comboEditSub1);
                dataBase.loadCombo($"select idNme2, nme from Sub2 where idNme = {idSub1}", "idNme2", "nme", comboEditSub2);
                dataBase.loadCombo($"select idNme3, nme from Sub3 where idNme2 = {idSub2}", "idNme3", "nme", comboEditSub3);
                dataBase.loadCombo($"select idProcess, nme from Proces where idNme3 = {idSub3}", "idProcess", "nme", comboEditProcess);
                textRto.Text = rto;
                textRtoPrev.Text = rtoPrev;
                //dataBase.loadCombo($"select * from FreqProcess", "idFreq", "nme", comboEditFreq);
                //dataBase.loadCombo($"select * from KindActivity", "idActiv", "nme", comboEditActiv);
                //textEditProc.Text = nameProcess;
            }
        }
    }
}
