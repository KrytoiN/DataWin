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
    public partial class modalAddRto : Form
    {
        public modalAddRto()
        {
            InitializeComponent();
            dataBase.loadCombo("select idNme, nme from Sub1", "idNme", "nme", comboSub1);
            formEditor.defaultSettingsCombo(comboSub1);
            formEditor.defaultSettingsCombo(comboSub2);
            formEditor.defaultSettingsCombo(comboSub3);
            formEditor.defaultSettingsCombo(comboProcess);
            formEditor.defaultSettingsCombo(comboDowntime);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (textRto.Text != "" && textRtoPrev.Text != "")
            {
                DialogResult = DialogResult.OK;
                this.Tag = new Rto(comboSub1.SelectedValue.ToString(), comboSub1.Text, comboSub2.SelectedValue.ToString(), comboSub2.Text, 
                    comboSub3.SelectedValue.ToString(), comboSub3.Text, comboProcess.SelectedValue.ToString(), comboProcess.Text,
                    combo2Hours.Text, combo4Hours.Text, combo8Hours.Text, combo24Hours.Text, combo5Days.Text, combo30Days.Text, comboDowntime.Text,
                    textRto.Text, textRtoPrev.Text);
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

        private void comboSub3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSub3.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboSub3.SelectedItem;
                int value = Convert.ToInt32(selectedRow.Row[0]);
                string query = "select idProcess, nme from Proces where idNme3 = " + value.ToString();
                dataBase.loadCombo(query, "idProcess", "nme", comboProcess);
            }
        }

        private void modalAddRto_Load(object sender, EventArgs e)
        {
            combo2Hours.DrawMode = DrawMode.OwnerDrawFixed;
            combo2Hours.DrawItem += combo2Hours_DrawItem;
            combo4Hours.DrawMode = DrawMode.OwnerDrawFixed;
            combo4Hours.DrawItem += combo4Hours_DrawItem;
            combo8Hours.DrawMode = DrawMode.OwnerDrawFixed;
            combo8Hours.DrawItem += combo8Hours_DrawItem;
            combo24Hours.DrawMode = DrawMode.OwnerDrawFixed;
            combo24Hours.DrawItem += combo24Hours_DrawItem;
            combo5Days.DrawMode = DrawMode.OwnerDrawFixed;
            combo5Days.DrawItem += combo5Days_DrawItem;
            combo30Days.DrawMode = DrawMode.OwnerDrawFixed;
            combo30Days.DrawItem += combo30Days_DrawItem;
        }

        private void combo2Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            formEditor.drawBackCombo(combo2Hours);
        }

        private void combo4Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            formEditor.drawBackCombo(combo4Hours);
        }

        private void combo8Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            formEditor.drawBackCombo(combo8Hours);
        }

        private void combo24Hours_SelectedIndexChanged(object sender, EventArgs e)
        {
            formEditor.drawBackCombo(combo24Hours);
        }

        private void combo5Days_SelectedIndexChanged(object sender, EventArgs e)
        {
            formEditor.drawBackCombo(combo5Days);
        }

        private void combo30Days_SelectedIndexChanged(object sender, EventArgs e)
        {
            formEditor.drawBackCombo(combo30Days);
        }

        private void combo2Hours_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                formEditor.drawDropDownCombo(combo2Hours, e);
            }
        }

        private void combo4Hours_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                formEditor.drawDropDownCombo(combo4Hours, e);
            }
        }


        private void combo8Hours_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                formEditor.drawDropDownCombo(combo8Hours, e);
            }
        }


        private void combo24Hours_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                formEditor.drawDropDownCombo(combo24Hours, e);
            }
        }

        private void combo5Days_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                formEditor.drawDropDownCombo(combo5Days, e);
            }
        }

        private void combo30Days_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                formEditor.drawDropDownCombo(combo30Days, e);
            }
        }
    }
}
