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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            /*if (loginForm.ShowDialog() != DialogResult.OK)
            {
                Close();
                return;
            }  */
            dataBase.Connect();
            dataBase.createTables();
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            addEditSub1 addEditSub1 = new addEditSub1();
            addEditSub1.Show();
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            addEditSub2 addEditSub2 = new addEditSub2();
            addEditSub2.Show();
        }

        private void btnSub3_Click(object sender, EventArgs e)
        {
            addEditSub3 addEditSub3 = new addEditSub3();
            addEditSub3.Show();
        }

        private void btnFreq_Click(object sender, EventArgs e)
        {
            addEditFreq addEditFreq = new addEditFreq();
            addEditFreq.Show();
        }

        private void btnActiv_Click(object sender, EventArgs e)
        {
            addEditActiv addEditActiv = new addEditActiv();
            addEditActiv.Show();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            addEditProcess addEditProces = new addEditProcess();
            addEditProces.Show();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnRto_Click(object sender, EventArgs e)
        {
            addEditRto addEditRto = new addEditRto();
            addEditRto.Show();
        }

        private void btnAddiction_Click(object sender, EventArgs e)
        {
            addEditAddiction addEditAddiction = new addEditAddiction();
            addEditAddiction.Show();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            addEditOwners addEditOwners = new addEditOwners();
            addEditOwners.Show();
        }

        private void btnRtoValues_Click(object sender, EventArgs e)
        {
            addEditRtoValues addEditRtoValues = new addEditRtoValues();
            addEditRtoValues.Show();
        }

        private void btnTarrifs_Click(object sender, EventArgs e)
        {
            addEditTariffs addEditTariffs = new addEditTariffs();
            addEditTariffs.Show();
        }
    }
}
