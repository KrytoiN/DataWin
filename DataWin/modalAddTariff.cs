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
    public partial class modalAddTariff : Form
    {
        public modalAddTariff()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textTariff.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Tag = new Tariff(formEditor.checkText(textTariff.Text), formEditor.checkText(textExp.Text));
                Close();
            }
            else
                MessageBox.Show("Введите название тарифа");
        }
    }
}
