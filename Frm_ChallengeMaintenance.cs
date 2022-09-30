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
    public partial class Frm_ChallengeMaintenance : Form
    {
        private static string filepath = @"c:\temp\NZESL.mdb";
        private int Row_Index = 1;

        public Frm_ChallengeMaintenance()
        {
            InitializeComponent();
        }

        private void Frm_ChallengeMaintenance_Load(object sender, EventArgs e)
        {
            this.eVENTTableAdapter1.Fill(this.nZESLDataSet1.EVENT);
            //Show access in the datagridview control
            AccessHelper.Access_Operation.Access_Open(filepath);
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Challenge", dataGridView1, "ChallengeID");
            //hide panel
            panel1.Visible = false;
            pnl_Event.Visible = false;
            cbo_EventID.Enabled = false;
            cbo_EventName.Enabled = false;
            //disable textbox
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            //textBox5.Enabled = false;
            //show the first challenge information
            string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");  //challenge id
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");         //challenge name
            textBox2.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");         //event id
            textBox3.Text = str;
            str = "select * from Event where EventID=" + textBox3.Text;
            str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);                                      //event name
            textBox4.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");         //time
            dateTimePicker1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");         //status
            comboBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");         //capacity
            numericUpDown1.Text = str;

            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Add Challenge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)   //btn add
        {
            //disable buttons
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            //reappear
            panel1.Visible = true;
            button8.Text = "Save Challenge";
            //disable textboxs
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            //show event panel
            pnl_Event.Visible = true;
            cbo_EventID.Enabled = true;
            cbo_EventName.Enabled = true;
            //clear textboxs
            textBox2.Text = "";
            comboBox1.Text = "";
            cbo_EventID.Text = "";
            cbo_EventName.Text = "";
            numericUpDown1.Text = "";
            dateTimePicker1.Text = "";

            //disable datagridview
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// Update Challenge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)   //btn update
        {
            //disable buttons
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            //reappear
            panel1.Visible = true;
            button8.Text = "Save Changes";
            //re-enable textboxs
            label3.Visible = false;
            textBox3.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = true;

            //disable datagridview
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)   //btn cancel
        {
            //Console.WriteLine(Row_Index);
            //disable buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            //reappear
            panel1.Visible = false;
            //panel2.Visible = false;
            //re-enable datagridview
            dataGridView1.Visible = true;
            AccessHelper.Access_Operation.Access_Open(filepath);
            textBox1.Visible = true;
            label1.Visible = true;
            //label3.Visible = true;
            //textBox3.Visible = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;

            //hide panel
            pnl_Event.Visible = false;
            cbo_EventID.Enabled = false;
            cbo_EventName.Enabled = false;

            //textBox1.Text = Row_Index.ToString();
            string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");//challenge name
            textBox2.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");//event id
            textBox3.Text = str;
            str = "select * from Event where EventID=" + textBox3.Text;
            str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
            textBox4.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");//time
            dateTimePicker1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");//status
            comboBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");//capacity
            numericUpDown1.Text = str;
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Insert or Update Challenge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)   //save
        {
            textBox1.Text = "holder";
            //check if empty
            if (groupBox1.Controls.Cast<Control>().Where(T => T is TextBox).Any(T => (T as TextBox).Text.Length == 0))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }
            else
            {
                //Pass and do something
                AccessHelper.Access_Operation.Access_Open(filepath);
                if (button8.Text == "Save Challenge")
                {
                    //insert new challenge
                    string sqlstr = "Insert into Challenge([ChallengeName],[EventID],[StartTime],[Status],[Capacity]) values('" + textBox2.Text + "','" + cbo_EventID.Text + "','" + dateTimePicker1.Text + "','" + comboBox1.Text + "','" + numericUpDown1.Text + "')";
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Challenge added successfully!");

                    //clear textboxs
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    cbo_EventID.Text = "";
                    cbo_EventName.Text = "";
                    numericUpDown1.Text = "";
                    dateTimePicker1.Text = "";
                }
                else if (button8.Text == "Save Changes")
                {
                    string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
                    textBox1.Text = str;
                    //update new employer
                    string sqlstr = "Update Challenge set " + "[ChallengeName]='" + textBox2.Text + "',[StartTime]='" + dateTimePicker1.Text + "',[Capacity]='" + numericUpDown1.Text + "' where [ChallengeID]=" + textBox1.Text;
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Challenge updated successfully!");
                    //disable buttons
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    //reappear
                    panel1.Visible = false;
                    //panel2.Visible = false;
                    //re-enable datagridview
                    dataGridView1.Visible = true;
                    AccessHelper.Access_Operation.Access_Open(filepath);
                    textBox1.Visible = true;
                    label1.Visible = true;
                    //label3.Visible = true;
                    //textBox3.Visible = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    comboBox1.Enabled = false;
                    numericUpDown1.Enabled = false;

                    //hide panel
                    pnl_Event.Visible = false;
                    cbo_EventID.Enabled = false;
                    cbo_EventName.Enabled = false;

                    //textBox1.Text = Row_Index.ToString();
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");//challenge name
                    textBox2.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");//event id
                    textBox3.Text = str;
                    str = "select * from Event where EventID=" + textBox3.Text;
                    str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                    textBox4.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");//time
                    dateTimePicker1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");//status
                    comboBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");//capacity
                    numericUpDown1.Text = str;
                }
                //reload dataGridView
                AccessHelper.Access_Operation.TransferAccessToDataGridView("Challenge", dataGridView1, "ChallengeID");
                AccessHelper.Access_Operation.Access_Close();
                //highlight
                dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 1].Cells[0];
            }

        }

        /// <summary>
        /// return main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)   //btn return
        {
            this.Hide();
            MainMenu MainM = new MainMenu();
            MainM.Show();
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)   //btn delete
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            string ChallengeID = textBox1.Text;
            string ChallengeName = textBox2.Text;
            string sqlstr = "select Challenge.ChallengeID,Challenge.ChallengeName,Entry.Status from Challenge,Entry where [Entry.ChallengeID]=[Challenge.ChallengeID] and [Challenge.ChallengeName]='" + textBox2.Text + "'";
            string Status = "";
            Status = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 3);
            if (Status == "")  //has no Entry
            {
                if (MessageBox.Show("The selected challenge has no entries, are you sure to delete the selected challenge?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlstr = "delete from Challenge where ChallengeID=" + textBox1.Text;
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Challenge deleted successfully!");
                    string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index - 1, 1, "ChallengeID");//challenge id
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index - 1, 2, "ChallengeID");//challenge name
                    textBox2.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index - 1, 3, "ChallengeID");//event id
                    textBox3.Text = str;
                    str = "select * from Event where EventID=" + textBox3.Text;
                    str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                    textBox4.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index - 1, 4, "ChallengeID");//time
                    dateTimePicker1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index - 1, 5, "ChallengeID");//status
                    comboBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index - 1, 6, "ChallengeID");//capacity
                    numericUpDown1.Text = str;

                    //reload dataGridView
                    AccessHelper.Access_Operation.TransferAccessToDataGridView("Challenge", dataGridView1, "ChallengeID");
                    //highlight
                    dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 2].Cells[0];
                }

            }
            else  //has Entries
            {
                MessageBox.Show("You may only delete a challenge that has no entries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)   //btn next
        {
            try
            {
                //Show access in the datagridview control
                AccessHelper.Access_Operation.Access_Open(filepath);
                //show the next information

                if (Row_Index < dataGridView1.Rows.Count - 1)
                {
                    Row_Index = Row_Index + 1;
                }
;
                string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");//challenge name
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");//event id
                textBox3.Text = str;
                str = "select * from Event where EventID=" + textBox3.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");//time
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");//status
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");//capacity
                numericUpDown1.Text = str;

                AccessHelper.Access_Operation.Access_Close();
                //highlight
                dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 1].Cells[0];
            }
            catch
            { }
        }

        /// <summary>
        /// Previous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)   //btn previous
        {
            try
            {
                //Show access in the datagridview control
                AccessHelper.Access_Operation.Access_Open(filepath);
                //show the previous information
                if (Row_Index > 1)
                {
                    Row_Index = Row_Index - 1;
                }

                string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");//challenge name
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");//event id
                textBox3.Text = str;
                str = "select * from Event where EventID=" + textBox3.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");//time
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");//status
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");//capacity
                numericUpDown1.Text = str;

                AccessHelper.Access_Operation.Access_Close();
                //highlight
                dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 1].Cells[0];
            }
            catch
            { }
        }

        /// <summary>
        /// select current row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)   //select current row
        {

            Row_Index = e.RowIndex + 1;
            try
            {
                //Show access in the datagridview control
                AccessHelper.Access_Operation.Access_Open(filepath);

                string str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 1);//challenge id
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 2);//challenge name
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 3);//event id
                textBox3.Text = str;
                str = "select * from Event where EventID=" + textBox3.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 4);//time
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 5);//status
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", e.RowIndex + 1, 6);//capacity
                numericUpDown1.Text = str;
                AccessHelper.Access_Operation.Access_Close();
            }
            catch
            { }
        }

        /// <summary>
        /// Mark Challenge as Completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)   //btn set as completed
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            string sqlstr = "select Status from Challenge where ChallengeID=" + textBox1.Text;
            string Status = "";
            Status = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 1);
            //Console.WriteLine(Status);
            if (Status == "Finished")
            {
                //sqlstr = "alter table [Vacancy] drop constraint";
                //AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                sqlstr = "Update Challenge set [Status]='Finished' where ChallengeID=" + textBox1.Text;
                AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                sqlstr = "Delete from Entry where ChallengeID=" + textBox1.Text;
                AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");//challenge name
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");//event id
                textBox3.Text = str;
                str = "select * from Event where EventID=" + textBox3.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");//time
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");//status
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");//capacity
                numericUpDown1.Text = str;
                MessageBox.Show("Challenge marked as completed!");
            }
            else 
            {
                MessageBox.Show("Only finished challenges can be marked as completed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Mark Challenge as Finished
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)   //btn set as finished
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            string sqlstr = "select Status from Challenge where ChallengeID=" + textBox1.Text;
            string Status = "";
            Status = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 1);
            //Console.WriteLine(Status);
            if (Status == "Scheduled")
            {
                //sqlstr = "alter table [Vacancy] drop constraint";
                //AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                sqlstr = "Update Challenge set [Status]='Finished' where ChallengeID=" + textBox1.Text;
                AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                string str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 1, "ChallengeID");//challenge id
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 2, "ChallengeID");//challenge name
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 3, "ChallengeID");//event id
                textBox3.Text = str;
                str = "select * from Event where EventID=" + textBox3.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);//event name
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 4, "ChallengeID");//time
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 5, "ChallengeID");//status
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Challenge", Row_Index, 6, "ChallengeID");//capacity
                numericUpDown1.Text = str;
                MessageBox.Show("Challenge marked as finished!");
            }
            else
            {
                MessageBox.Show("Only scheduled challenges can be marked as finished!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AccessHelper.Access_Operation.Access_Close();
        }

    }
}
