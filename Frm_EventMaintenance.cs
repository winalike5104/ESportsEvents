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
    public partial class Frm_EventMaintenance : Form
    {
        private static string filepath = @"c:\temp\NZESL.mdb";
        private static int Row_Index;

        public Frm_EventMaintenance()
        {
            InitializeComponent();
        }

        private void Frm_EventMaintenance_Load(object sender, EventArgs e)
        {
            this.aRENATableAdapter1.Fill(this.nZESLDataSet1.ARENA);
            Row_Index = 1;
            //Show access in the datagridview control
            AccessHelper.Access_Operation.Access_Open(filepath);
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Event", dataGridView1, "EventName", "EventID");
            //hide panel
            panel1.Visible = false;
            pnl_Arena.Visible = false;
            cbo_ArenaID.Enabled = false;
            cbo_ArenaName.Enabled = false;
            //disable textbox
            textBox1.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            dateTimePicker1.Enabled = false;
            //show the first information
            string str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 1, "EventID");      //id
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 2, "EventID");             //name
            textBox6.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 3, "EventID");             //arena id
            textBox2.Text = str;
            str = "select * from Arena where ArenaID=" + textBox2.Text;                                     //arena name
            str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);
            textBox3.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 4, "EventID");             //status
            comboBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 5, "EventID");             //capacity
            numericUpDown1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 6, "EventID");             //date
            dateTimePicker1.Text = str;
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Add Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)   //btn_add
        {
            //disable buttons
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            //reappear
            panel1.Visible = true;
            button8.Text = "Save Meeting";
            //re-enable textboxs
            label1.Visible = false;
            //label2.Visible = false;
            //label3.Visible = false;
            //textBox2.Visible = false;
            //textBox3.Visible = false;
            textBox1.Visible = false;
            textBox6.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            dateTimePicker1.Enabled = true;
            //show arena panel
            pnl_Arena.Visible = true;
            cbo_ArenaID.Enabled = true;
            cbo_ArenaName.Enabled = true;
            //clear textboxs
            textBox1.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            cbo_ArenaID.Text = "";
            cbo_ArenaName.Text = "";
            numericUpDown1.Text = "";
            dateTimePicker1.Text = "";

            //disable datagridview
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// Update Event
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
            //reappear
            panel1.Visible = true;
            button8.Text = "Save Changes";
            //re-enable textboxs
            textBox1.Enabled = false;
            textBox6.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;
            dateTimePicker1.Enabled = true;

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
            //disable buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            //reappear
            panel1.Visible = false;
            //re-enable datagridview
            dataGridView1.Visible = true;
            AccessHelper.Access_Operation.Access_Open(filepath);
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Enabled = false;
            textBox6.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            dateTimePicker1.Enabled = false;
            //hide arena panel
            pnl_Arena.Visible = false;
            cbo_ArenaID.Enabled = false;
            cbo_ArenaName.Enabled = false;

            //textBox1.Text = Row_Index.ToString();

            string str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 1, "EventID");
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 2, "EventID");
            textBox6.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 3, "EventID");
            textBox2.Text = str;
            str = "select * from Arena where ArenaID=" + textBox2.Text;
            str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);
            textBox3.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 4, "EventID");
            comboBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 5, "EventID");
            numericUpDown1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 6, "EventID");
            dateTimePicker1.Text = str;
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Insert or Update Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)   //btn add/save
        {
            textBox1.Text = "holder";
            textBox2.Text = "holder";
            textBox3.Text = "holder";
            //check if empty
            if (groupBox1.Controls.Cast<Control>().Where(T => T is TextBox).Any(T => (T as TextBox).Text.Length == 0))
            {
                MessageBox.Show("Please fill in all required fields");
                return;
            }
            else
            {
                AccessHelper.Access_Operation.Access_Open(filepath);
                if (button8.Text == "Save Meeting")
                {
                    //insert new event
                    string sqlstr = "Insert into Event([EventName],[ArenaID],[Status],[Capacity],[EventDate]) values('" + textBox6.Text + "','" + cbo_ArenaID.Text + "','" + comboBox1.Text + "','" + numericUpDown1.Text + "','" + dateTimePicker1.Text + "')";
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Event added successfully!");

                    //clear textboxs
                    textBox1.Text = "";
                    textBox6.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox1.Text = "";
                    cbo_ArenaID.Text = "";
                    cbo_ArenaName.Text = "";
                    numericUpDown1.Text = "";
                    dateTimePicker1.Text = "";
                }
                else if (button8.Text == "Save Changes")
                {
                    string str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 1, "EventID");
                    textBox1.Text = str;
                    //update event
                    string sqlstr = "Update Event set " + "[EventName]='" + textBox6.Text + "',[Status]='" + comboBox1.Text + "',[Capacity]='" + numericUpDown1.Text + "',[EventDate]='" + dateTimePicker1.Text + "' where [EventID]=" + textBox1.Text;
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Event updated successfully!");
                    //disable buttons
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    //reappear
                    panel1.Visible = false;
                    //re-enable datagridview
                    dataGridView1.Visible = true;
                    textBox1.Visible = true;
                    label1.Visible = true;
                    textBox1.Enabled = false;
                    textBox6.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    comboBox1.Enabled = false;
                    numericUpDown1.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    //hide arena panel
                    pnl_Arena.Visible = false;
                    cbo_ArenaID.Enabled = false;
                    cbo_ArenaName.Enabled = false;

                    //textBox1.Text = Row_Index.ToString();

                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 1, "EventID");
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 2, "EventID");
                    textBox6.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 3, "EventID");
                    textBox2.Text = str;
                    str = "select * from Arena where ArenaID=" + textBox2.Text;
                    str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);
                    textBox3.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 4, "EventID");
                    comboBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 5, "EventID");
                    numericUpDown1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 6, "EventID");
                    dateTimePicker1.Text = str;
                }
                //reload dataGridView
                AccessHelper.Access_Operation.TransferAccessToDataGridView("Event", dataGridView1, "EventName", "EventID");
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
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainM = new MainMenu();
            MainM.Show();
        }

        /// <summary>
        /// Delete Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button5_Click(object sender, EventArgs e)   //btn delete
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            string EventName = textBox6.Text;
            string sqlstr = "select Event.EventID,Event.EventName,Challenge.Status from Event,Challenge where [Challenge.EventID]=[Event.EventID] and [Event.EventName]='" + textBox6.Text + "'";
            string Status = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 3);
            //Console.WriteLine(Status);
            if (Status == "")  //has no challenges
            {
                if (MessageBox.Show("The selected event has no challenges, are you sure to delete the selected event?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //sqlstr = "alter table arena drop constraint"+;
                    //AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    sqlstr = "delete from Event where EventName='" + textBox6.Text +"'";
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Event deleted successfully!");
                    //reload previous event infomation
                    string str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index - 1, 1, "EventID");
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index - 1, 2, "EventID");
                    textBox6.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index - 1, 3, "EventID");
                    textBox2.Text = str;
                    str = "select * from Arena where ArenaID=" + textBox2.Text;
                    str = AccessHelper.Access_Operation.GetCellValuebySql(str, 2);
                    textBox3.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index - 1, 4, "EventID");
                    comboBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index - 1, 5, "EventID");
                    numericUpDown1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index - 1, 6, "EventID");
                    dateTimePicker1.Text = str;

                    //reload dataGridView
                    AccessHelper.Access_Operation.TransferAccessToDataGridView("Event", dataGridView1, "EventName", "EventID");
                    //highlight
                    dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 2].Cells[0];
                }


            }
            else  //has challenges
            {
                MessageBox.Show("You may only delete events that have no challenges!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                string str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 1, "EventID");
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 2, "EventID");
                textBox6.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 3, "EventID");
                textBox2.Text = str;
                string sqlstr = "select * from Arena where ArenaID=" + textBox2.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 2);
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 4, "EventID");
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 5, "EventID");
                numericUpDown1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 6, "EventID");
                dateTimePicker1.Text = str;
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

                string str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 1, "EventID");
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 2, "EventID");
                textBox6.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 3, "EventID");
                textBox2.Text = str;
                string sqlstr = "select * from Arena where ArenaID=" + textBox2.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 2);
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 4, "EventID");
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 5, "EventID");
                numericUpDown1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", Row_Index, 6, "EventID");
                dateTimePicker1.Text = str;
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
                string str = AccessHelper.Access_Operation.GetCellValue("Event", e.RowIndex + 1, 1);
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", e.RowIndex + 1, 2);
                textBox6.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", e.RowIndex + 1, 3);
                textBox2.Text = str;
                string sqlstr = "select * from Arena where ArenaID=" + textBox2.Text;
                str = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 2);
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", e.RowIndex + 1, 4);
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", e.RowIndex + 1, 5);
                numericUpDown1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Event", e.RowIndex + 1, 6);
                dateTimePicker1.Text = str;
                AccessHelper.Access_Operation.Access_Close();
            }
            catch
            { }

        }

    }
}
