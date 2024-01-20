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
    public partial class modalAddSub2 : Form
    {
        public modalAddSub2()
        {
            InitializeComponent();
            dataBase.loadCombo("select idNme, nme from Sub1", "idNme", "nme", comboSub1);
            formEditor.defaultSettingsCombo(comboSub1);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textSub2.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Tag = new Sub2(comboSub1.SelectedValue.ToString(), comboSub1.Text, textSub2.Text);
                Close();
            }
            else
                MessageBox.Show("Введите название подразделения");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
