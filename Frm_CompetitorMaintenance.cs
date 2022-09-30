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
    public partial class Frm_CompetitorMaintenance : Form
    {
        private static string filepath = @"c:\temp\NZESL.mdb";
        private static int Row_Index;

        public Frm_CompetitorMaintenance()
        {
            InitializeComponent();
        }

        private void Frm_CompetitorMaintenance_Load(object sender, EventArgs e)
        {

            Row_Index = 1;
            //Show access in the datagridview control
            AccessHelper.Access_Operation.Access_Open(filepath);
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Competitor", dataGridView1, "UserName");
            //hide panel
            panel1.Visible = false;
            rad_Fe.Visible = false;
            rad_Ma.Visible = false;
            rad_O.Visible = false;
            rad_Fe.Checked = true;
            //disable textbox
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            dateTimePicker1.Enabled = false;
            //show the first information
            string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 1, "CompetitorID");    //id
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 2, "CompetitorID");           //username
            textBox2.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 7, "CompetitorID");           //firstname
            textBox3.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 3, "CompetitorID");           //lastname
            textBox4.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 4, "CompetitorID");           //gender
            textBox5.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 5, "CompetitorID");           //dob
            //Console.WriteLine(str);
            dateTimePicker1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 6, "CompetitorID");           //email
            textBox6.Text = str;

            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Add Competitor
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

            //reappear
            panel1.Visible = true;
            button8.Text = "Save Competitor";
            rad_Fe.Visible = true;
            rad_Ma.Visible = true;
            rad_O.Visible = true;
            rad_Fe.Checked = true;
            textBox5.Visible = false;
            //disable textboxs
            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
            dateTimePicker1.Enabled = true;

            //clear textboxs
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            dateTimePicker1.Text = "";

            //disable datagridview
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// rdo Gender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private int GetGender()
        {
            string gender = "";
            int gender_btn;
            AccessHelper.Access_Operation.Access_Open(filepath);
            string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 4, "CompetitorID");//
            gender = str;
            if (gender == "Female")
            {
                gender_btn = 1;
            }
            else if (gender == "Male")
            {
                gender_btn = 2;
            }
            else
            {
                gender_btn = 3;
            }
            return gender_btn;

        }

        /// <summary>
        /// set Gender
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private string CheckRB()
        {
            string checkedRBText = "";

            //get radiobutton text
            if (rad_Fe.Checked)
            {
                checkedRBText = rad_Fe.Text;
            }
            else if (rad_Ma.Checked)
            {
                checkedRBText = rad_Ma.Text;
            }
            else
            {
                checkedRBText = rad_O.Text;
            }
            return checkedRBText;
        }

        /// <summary>
        /// Update Competitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void button4_Click(object sender, EventArgs e)   //btn update
        {
            int genderCode = GetGender();
            //disable buttons
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;

            //reappear
            panel1.Visible = true;
            button8.Text = "Save Changes";
            rad_Fe.Visible = true;
            rad_Ma.Visible = true;
            rad_O.Visible = true;
            textBox5.Visible = false;
            if (genderCode == 1)
            {
                rad_Fe.Checked = true;
            }
            else if (genderCode == 2)
            {
                rad_Ma.Checked = true;
            }
            else
            {
                rad_O.Checked = true;
            }
            //re-enable textboxs

            label1.Visible = false;
            textBox1.Visible = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;
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
            //Console.WriteLine(Row_Index);
            //disable buttons
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;

            //reappear
            panel1.Visible = false;
            rad_Fe.Visible = false;
            rad_Ma.Visible = false;
            rad_O.Visible = false;

            textBox5.Visible = true;
            //re-enable datagridview
            dataGridView1.Visible = true;
            //show the current
            AccessHelper.Access_Operation.Access_Open(filepath);
            textBox1.Visible = true;
            label1.Visible = true;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            dateTimePicker1.Enabled = false;

            //textBox1.Text = Row_Index.ToString();
            string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 1, "CompetitorID");
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 2, "CompetitorID");
            textBox2.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 7, "CompetitorID");
            textBox3.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 3, "CompetitorID");
            textBox4.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 4, "CompetitorID");
            textBox5.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 5, "CompetitorID");
            dateTimePicker1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 6, "CompetitorID");
            textBox6.Text = str;
            AccessHelper.Access_Operation.Access_Close();
        }


        /// <summary>
        /// Insert or Update Competitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
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
                AccessHelper.Access_Operation.Access_Open(filepath);
                if (button8.Text == "Save Competitor")
                {
                    string checkedRBText = this.CheckRB();
                    //insert new competitor
                    string sqlstr = "Insert into Competitor([UserName],[FirstName],[LastName],[Gender],[DateOfBirth],[EmailAddress]) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + checkedRBText + "','" + dateTimePicker1.Text + "','" + textBox6.Text + "')";
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Competitor added successfully!");

                    //clear textboxs
                    rad_Fe.Checked = true;
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox6.Text = "";
                    dateTimePicker1.Text = "";
                }
                else if (button8.Text == "Save Changes")
                {
                    string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 1, "CompetitorID");
                    textBox1.Text = str;
                    string checkedRBText = this.CheckRB();
                    //Console.WriteLine(checkedRBText);
                    //update competitor
                    string sqlstr = "Update Competitor set " + "[UserName]='" + textBox2.Text + "',[FirstName]='" + textBox3.Text + "',[LastName]='" + textBox4.Text + "',[Gender]='" + checkedRBText + "',[DateOfBirth]='" + dateTimePicker1.Text + "',[EmailAddress]='" + textBox6.Text + "' where [CompetitorID]=" + textBox1.Text;
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Competitor updated successfully!");
                    //Console.WriteLine(Row_Index);
                    //disable buttons
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;

                    //reappear
                    panel1.Visible = false;
                    rad_Fe.Visible = false;
                    rad_Ma.Visible = false;
                    rad_O.Visible = false;

                    textBox5.Visible = true;
                    //re-enable datagridview
                    dataGridView1.Visible = true;
                    //show the current employer information
                    AccessHelper.Access_Operation.Access_Open(filepath);
                    textBox1.Visible = true;
                    label1.Visible = true;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    dateTimePicker1.Enabled = false;

                    //textBox1.Text = Row_Index.ToString();
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 1, "CompetitorID");
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 2, "CompetitorID");
                    textBox2.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 7, "CompetitorID");
                    textBox3.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 3, "CompetitorID");
                    textBox4.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 4, "CompetitorID");
                    textBox5.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 5, "CompetitorID");
                    dateTimePicker1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 6, "CompetitorID");
                    textBox6.Text = str;
                }
                AccessHelper.Access_Operation.TransferAccessToDataGridView("Competitor", dataGridView1, "UserName");
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
        /// Delete Competitor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)   //btn delete
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            string CompetitorID = textBox1.Text;
            string CompetitorName = textBox2.Text;
            string sqlstr = "select Competitor.CompetitorID,Competitor.UserName,Entry.Status from Competitor,Entry where [Entry.CompetitorID]=[Competitor.CompetitorID] and [Competitor.UserName]='" + textBox2.Text + "'";
            string Status = "";
            Status = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 3);
            if (Status == "")  //has no Entry
            {
                if (MessageBox.Show("The selected competitor has no entries, are you sure to delete the selected competitor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlstr = "delete from Competitor where CompetitorID=" + textBox1.Text;
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Competitor deleted successfully!");
                    string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 1, "CompetitorID");
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 2, "CompetitorID");
                    textBox2.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 7, "CompetitorID");
                    textBox3.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 3, "CompetitorID");
                    textBox4.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 4, "CompetitorID");
                    textBox5.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 5, "CompetitorID");
                    dateTimePicker1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index - 1, 6, "CompetitorID");
                    textBox6.Text = str;

                    //reload dataGridView
                    AccessHelper.Access_Operation.TransferAccessToDataGridView("Competitor", dataGridView1, "UserName");
                    //highlight
                    Row_Index -= 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 1].Cells[0];
                }

            }
            else  //has entries
            {
                MessageBox.Show("You may only delete competitors that have no entries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 1, "CompetitorID");
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 2, "CompetitorID");
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 7, "CompetitorID");
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 3, "CompetitorID");
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 4, "CompetitorID");
                textBox5.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 5, "CompetitorID");
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 6, "CompetitorID");
                textBox6.Text = str;

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

                string str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 1, "CompetitorID");
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 2, "CompetitorID");
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 7, "CompetitorID");
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 3, "CompetitorID");
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 4, "CompetitorID");
                textBox5.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 5, "CompetitorID");
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", Row_Index, 6, "CompetitorID");
                textBox6.Text = str;

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
                string str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 1);//challenge id
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 2);//challenge name
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 7);//event id
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 3);//event id
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 4);//time
                textBox5.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 5);//status
                                                                                                             //Console.WriteLine(str);
                dateTimePicker1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Competitor", e.RowIndex + 1, 6);//capacity
                textBox6.Text = str;
                AccessHelper.Access_Operation.Access_Close();
            }
            catch
            { }


        }
    }
}

