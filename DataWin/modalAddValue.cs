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
    public partial class modalAddValue : Form
    {
        public modalAddValue(string formName, string labelText)
        {
            InitializeComponent();
            labelValue.Text = labelText;
            this.Text = formName;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textValue.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Tag = formEditor.checkText(textValue.Text);
                Close();
            }
            else
                MessageBox.Show(labelValue.Text);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
