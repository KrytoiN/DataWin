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
    public partial class modalAddProcess : Form
    {
        public modalAddProcess()
        {
            InitializeComponent();
            dataBase.loadCombo("select * from Sub1", "idNme", "nme", comboSub1);
            dataBase.loadCombo("select * from FreqProcess", "idFreq", "nme", comboFreq);
            dataBase.loadCombo("select * from KindActivity", "idActiv", "nme", comboActiv);
            dataBase.loadCombo($"select * from OwnerProces", "idOwner", "nme", comboOwner);
            dataBase.loadCombo($"select * from RtoValues", "idRto", "nme", comboRtoVal);
            dataBase.loadCombo($"select * from Tariffs", "idTariff", "nme", comboTariff);
            formEditor.defaultSettingsCombo(comboSub1);
            formEditor.defaultSettingsCombo(comboSub2);
            formEditor.defaultSettingsCombo(comboSub3);
            formEditor.defaultSettingsCombo(comboFreq);
            formEditor.defaultSettingsCombo(comboActiv);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textProc.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Tag = new Process(comboSub1.SelectedValue.ToString(), comboSub1.Text, comboSub2.SelectedValue.ToString(), comboSub2.Text, comboSub3.SelectedValue.ToString(), comboSub3.Text, comboFreq.SelectedValue.ToString(), comboFreq.Text, comboActiv.SelectedValue.ToString(), comboActiv.Text,
                    comboOwner.SelectedValue.ToString(), comboOwner.Text, comboRtoVal.SelectedValue.ToString(), comboRtoVal.Text, textRtoPrev.Text, comboTariff.SelectedValue.ToString(), comboTariff.Text, textProc.Text);
                Close();
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void comboSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSub1.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboSub1.SelectedItem;
                int value = Convert.ToInt32(selectedRow.Row[0]);
                string query = "select idNme2, nme from Sub2 where idNme = " + value.ToString();
                dataBase.loadCombo(query, "idNme2", "nme", comboSub2);
            }
        }

        private void comboSub2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSub2.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboSub2.SelectedItem;
                int value = Convert.ToInt32(selectedRow.Row[0]);
                string query = "select idNme3, nme from Sub3 where idNme2 = " + value.ToString();
                dataBase.loadCombo(query, "idNme3", "nme", comboSub3);
            }
        }
    }
}
