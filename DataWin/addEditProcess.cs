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
    public partial class addEditProcess : Form
    {
        int i;
        public addEditProcess()
        {
            InitializeComponent();
            formEditor.setName(dataGridProcess, "Proces");
            dataBase.loadData(dataGridProcess);
            formEditor.defaultSettings(dataGridProcess);
            formEditor.defaultSettingsCombo(comboEditSub1);
            formEditor.defaultSettingsCombo(comboEditSub2);
            formEditor.defaultSettingsCombo(comboEditSub3);
            formEditor.defaultSettingsCombo(comboEditActiv);
            formEditor.defaultSettingsCombo(comboEditFreq);
            formEditor.defaultSettingsCombo(comboEditOwner);
            formEditor.defaultSettingsCombo(comboEditRtoVal);
            formEditor.defaultSettingsCombo(comboEditTariff);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (textEditProc.Text != "" && comboEditSub2.SelectedValue.ToString() != "-1")
            {
                Process proc = new Process(comboEditSub1.SelectedValue.ToString(), comboEditSub1.Text, comboEditSub2.SelectedValue.ToString(), comboEditSub2.Text, comboEditSub3.SelectedValue.ToString(), comboEditSub3.Text,
                    comboEditFreq.SelectedValue.ToString(), comboEditFreq.Text, comboEditActiv.SelectedValue.ToString(), comboEditActiv.Text, comboEditOwner.SelectedValue.ToString(), comboEditOwner.Text, comboEditRtoVal.SelectedValue.ToString(), comboEditRtoVal.Text,
                    textEditRtoPrev.Text, comboEditTariff.SelectedValue.ToString(), comboEditTariff.Text, textEditProc.Text);
                string id = dataGridProcess.Rows[i].Cells[0].Value.ToString();
                string query = proc.queryUpdate(id);
                if (MessageBox.Show(formEditor.formMessage(dataGridProcess, i, proc.ToStringArray()), "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (dataBase.updateValue(query))
                    {
                        formEditor.updateValues(dataGridProcess, i, proc.ToStringArray());
                        formEditor.addGridTags(dataGridProcess, i, proc.ToStringTags());
                    }
                    else
                        MessageBox.Show("Не удалось обновить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Введите название процесса или привяжите к выбранному Подразделению ур.1 - Подразделение ур.2 - Подразделение ур.3", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            modalAddProcess modal = new modalAddProcess();
            if (modal.ShowDialog() == DialogResult.OK)
            {
                Process value = modal.Tag as Process;
                string query = value.queryAdd();
                string id = dataBase.addValue(query);
                if (id != "")
                {
                    int index = formEditor.addGridValues(dataGridProcess, id, value.ToStringArray());
                    formEditor.addGridTags(dataGridProcess, index, value.ToStringTags());
                }
                else
                    MessageBox.Show("При добавлении данных произошла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if (dataGridProcess?.CurrentCell != null)
            {
                if (MessageBox.Show("Вы уверены что хотите удалить значение?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int index = dataGridProcess.CurrentCell.RowIndex;
                    if (!dataBase.delValue(dataGridProcess.Name, dataGridProcess.Columns[0].Name, dataGridProcess.Rows[index].Cells[0].Value.ToString()))
                        MessageBox.Show("Не получилось удалить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridProcess.Rows.RemoveAt(index);
                }
            }
            else
                MessageBox.Show("Нельзя удалять, больше ничего нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboEditSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEditSub1.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboEditSub1.SelectedItem;
                int value = Convert.ToInt32(selectedRow.Row[0]);
                string query = "select idNme2, nme from Sub2 where idNme = " + value.ToString();
                dataBase.loadCombo(query, "idNme2", "nme", comboEditSub2);
            }
        }

        private void comboEditSub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEditSub2.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboEditSub2.SelectedItem;
                int value = Convert.ToInt32(selectedRow.Row[0]);
                string query = "select idNme3, nme from Sub3 where idNme2 = " + value.ToString();
                dataBase.loadCombo(query, "idNme3", "nme", comboEditSub3);
            }
        }

        private void dataGridProcess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.RowIndex != -1) && (e.ColumnIndex != -1))
            {
                i = e.RowIndex;
                string idSub1 = dataGridProcess.Rows[i].Cells["idNme"].Tag.ToString();
                string idSub2 = dataGridProcess.Rows[i].Cells["idNme2"].Tag.ToString();
                string idSub3 = dataGridProcess.Rows[i].Cells["idNme3"].Tag.ToString();
                string nameProcess = dataGridProcess.Rows[i].Cells["nme"].Tag.ToString();
                dataBase.loadCombo($"select * from Sub1", "idNme", "nme", comboEditSub1);
                comboEditSub1.SelectedValue = idSub1;
                dataBase.loadCombo($"select idNme2, nme from Sub2 where idNme = {idSub1}", "idNme2", "nme", comboEditSub2);
                comboEditSub2.SelectedValue = idSub2;
                dataBase.loadCombo($"select idNme3, nme from Sub3 where idNme2 = {idSub2}", "idNme3", "nme", comboEditSub3);
                comboEditSub3.SelectedValue = idSub3;
                dataBase.loadCombo($"select * from FreqProcess", "idFreq", "nme", comboEditFreq);
                dataBase.loadCombo($"select * from KindActivity", "idActiv", "nme", comboEditActiv);
                dataBase.loadCombo($"select * from OwnerProces", "idOwner", "nme", comboEditOwner);
                dataBase.loadCombo($"select * from RtoValues", "idRto", "nme", comboEditRtoVal);
                dataBase.loadCombo($"select * from Tariffs", "idTariff", "nme", comboEditTariff);
                textEditProc.Text = nameProcess;
            }
        }
    }
}
