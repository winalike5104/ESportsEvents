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
    public partial class Frm_EntryMaintenance : Form
    {
        public Frm_EntryMaintenance()
        {
            InitializeComponent();
        }

        private static string filepath = @"c:\temp\NZESL.mdb";
        private int Row_Index = 1;

        private void Frm_AssignSkillToCandidate_Load(object sender, EventArgs e)
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Competitor", dataGridView1, "CompetitorID, UserName, FirstName, LastName, Gender, DateOfBirth, EmailAddress", "CompetitorID");
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Challenge", dataGridView2, "ChallengeID, ChallengeName, EventID, StartTime, Status, Capacity", "ChallengeID");
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Entry", dataGridView3, "ChallengeID, CompetitorID, Status", "ChallengeID, CompetitorID");
            //disable textbox
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;

            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Add Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            string ChallengeStatus = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            string strCompID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string strChaID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            int CompID, ChaID;
            int.TryParse(strCompID, out CompID);
            int.TryParse(strChaID, out ChaID);
            //Console.WriteLine(ChallengeStatus);
            //Console.WriteLine("compid:"+CompID+ "chaid:"+ ChaID);
            AccessHelper.Access_Operation.Access_Open(filepath);
            //int ChallengeID = int.Parse(dataGridView2.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString());

            //string sqlstr = "select CandidateID from CandidateSKILL where SkillID=" + SkillID;
            if (ChallengeStatus == "Scheduled")  //Scheduled
            {
                string sqlstr = "Insert into Entry([ChallengeID],[CompetitorID],[Status]) values('" + ChaID + "','" + CompID + "','" + comboBox1.Text + "')";
                AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                MessageBox.Show("Entry added successfully!");
                AccessHelper.Access_Operation.TransferAccessToDataGridView("Entry", dataGridView3, "ChallengeID, CompetitorID, Status", "ChallengeID, CompetitorID");
            }
            else  //no scheduled
            {
                MessageBox.Show("Competitors can only be entered to scheduled challenges!", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Remove Entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string strCompID = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            string strChaID = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            int CompID, ChaID;
            int.TryParse(strCompID, out CompID);
            int.TryParse(strChaID, out ChaID);

            if (MessageBox.Show("Are you sure to remove the entry record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AccessHelper.Access_Operation.Access_Open(filepath);
                string sqlstr = "delete from Entry where ChallengeID=" + ChaID + "and CompetitorID=" + CompID;
                AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                MessageBox.Show("Entry removed successfully!");
                //reload dataGridView
                AccessHelper.Access_Operation.TransferAccessToDataGridView("Entry", dataGridView3, "ChallengeID, CompetitorID, Status", "ChallengeID, CompetitorID");
            }
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// return main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainM = new MainMenu();
            MainM.Show();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Row_Index = e.RowIndex + 1;
            //Console.WriteLine(Row_Index);
            try
            {
                //Show access in the datagridview control
                AccessHelper.Access_Operation.Access_Open(filepath);

                string compId = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 1);
                //Console.WriteLine(compId);

                AccessHelper.Access_Operation.Access_Close();
            }
            catch
            { }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)   //select current row
        {

            Row_Index = e.RowIndex + 1;
            //Console.WriteLine(Row_Index);
            try
            {
                //Show access in the datagridview control
                AccessHelper.Access_Operation.Access_Open(filepath);

                string status = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 5);
                string str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 3);
                //int eventId;
                //int.TryParse(str, out eventId);
                string sqlstr = "select * from Event where [Event.EventID]= "+ str;
                string eventName = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 2);
                string status_e = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 4);
                textBox1.Text = eventName;
                textBox2.Text = status_e;

                if (status == "Scheduled")
                {
                    comboBox1.Enabled = true;
                }
                else
                {
                    comboBox1.Enabled = false;
                }

      
                AccessHelper.Access_Operation.Access_Close();
            }
            catch
            { }
        }

    }
}
