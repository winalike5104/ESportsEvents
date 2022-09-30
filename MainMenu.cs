using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESportsEvents
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ArenaMaintenance EmpMain = new Frm_ArenaMaintenance();
            EmpMain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_EventMaintenance CandMain = new Frm_EventMaintenance();
            CandMain.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_ChallengeMaintenance VacMain = new Frm_ChallengeMaintenance();
            VacMain.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_CompetitorMaintenance AssSkill = new Frm_CompetitorMaintenance();
            AssSkill.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_EntryMaintenance AssCand = new Frm_EntryMaintenance();
            AssCand.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_PrintEvent PrinCan = new Frm_PrintEvent();
            PrinCan.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_PrintCompetitor PrinVac = new Frm_PrintCompetitor();
            PrinVac.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
