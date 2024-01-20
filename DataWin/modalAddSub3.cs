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
    public partial class modalAddSub3 : Form
    {
        public modalAddSub3()
        {
            InitializeComponent();
            dataBase.loadCombo("select idNme, nme from Sub1", "idNme", "nme", comboSub1);
            formEditor.defaultSettingsCombo(comboSub1);
            formEditor.defaultSettingsCombo(comboSub2);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textSub3.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Tag = new Sub3(comboSub1.SelectedValue.ToString(), comboSub1.Text, comboSub2.SelectedValue.ToString(), comboSub2.Text, formEditor.checkText(textSub3.Text));
                Close();
            }
            else
                MessageBox.Show("Введите название подразделения ур.3");
        }

        private void comboSub1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSub1.SelectedIndex != -1)
            {
                comboSub2.Enabled = true;
                DataRowView selectedRow = (DataRowView)comboSub1.SelectedItem;
                int value = Convert.ToInt32(selectedRow.Row[0]);
                string query = "select idNme2, nme from Sub2 where idNme = " + value.ToString();
                dataBase.loadCombo(query, "idNme2", "nme", comboSub2);
            }
            else
                comboSub2.Enabled = false;
        }
    }
}
