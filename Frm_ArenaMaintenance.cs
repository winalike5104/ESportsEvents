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
    public partial class Frm_ArenaMaintenance : Form
    {
        private static string filepath=@"c:\temp\NZESL.mdb";
        private int Row_Index = 1;


        public Frm_ArenaMaintenance()
        {
            InitializeComponent();
        }

        private void Frm_ArenaMaintenance_Load(object sender, EventArgs e)
        {
            //Show access in the datagridview control
            AccessHelper.Access_Operation.Access_Open(filepath);
            AccessHelper.Access_Operation.TransferAccessToDataGridView("Arena", dataGridView1, "ArenaName");
            //hide panel
            panel1.Visible = false;
            //disable textbox
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox1.Enabled = false;
            //show the first arena information
            string str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 1); //id
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 2);        //name
            textBox2.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 3);        //address
            textBox3.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 4);        //suburb
            textBox4.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 5);        //city
            comboBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 6);        //phone
            textBox5.Text = str;
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Add Arena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)   //btn add Arena
        {
            //disable buttons
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            //reappear
            panel1.Visible = true;
            button8.Text = "Save Arena";
            //clear textboxs
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            //re-enable textboxs
            textBox1.Visible = false;
            label1.Visible = false;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
            //disable datagridview
            dataGridView1.Visible = false;
        }

        /// <summary>
        /// Update Arena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)   //btn updateArena
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
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox1.Enabled = true;
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
            //show the current arena information
            AccessHelper.Access_Operation.Access_Open(filepath);
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox1.Enabled = false;
            //refresh arena information
            string str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 1);
            textBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 2);
            textBox2.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 3);
            textBox3.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 4);
            textBox4.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 5);
            comboBox1.Text = str;
            str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 6);
            textBox5.Text = str;
            AccessHelper.Access_Operation.Access_Close();
        }

        /// <summary>
        /// Insert or Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)   //btn save arena
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
                if (button8.Text == "Save Arena")
                {
                    //insert new arena
                    string sqlstr = "Insert into Arena([ArenaName],[StreetAddress],[Suburb],[City],[PhoneNumber]) values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')";
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Arena added successfully!");

                    //clear textboxs
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    comboBox1.Text = "";
                }
                else if (button8.Text == "Save Changes")
                {
                    string str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 1);
                    textBox1.Text = str;
                    //update new arena
                    string sqlstr = "Update Arena set " + "[ArenaName]='" + textBox2.Text + "',[StreetAddress]='" + textBox3.Text + "',[Suburb]='" + textBox4.Text + "',[City]='" + comboBox1.Text + "',[PhoneNumber]='" + textBox5.Text + "' where [ArenaID]=" + textBox1.Text;
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Arena updated successfully!");

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
                    //show the current arena information
                    textBox1.Visible = true;
                    label1.Visible = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    comboBox1.Enabled = false;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 1);
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 2);
                    textBox2.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 3);
                    textBox3.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 4);
                    textBox4.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 5);
                    comboBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 6);
                    textBox5.Text = str;
                }
                //reload dataGridView
                AccessHelper.Access_Operation.TransferAccessToDataGridView("ARENA", dataGridView1, "ArenaName");
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
        /// Delete Arena
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)   //btn delete
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            string ArenaName = textBox2.Text;
            string sqlstr = "select Arena.ArenaID,Arena.ArenaName,EVENT.Status from EVENT,Arena where [EVENT.ArenaID]=[Arena.ArenaID] and [Arena.ArenaName]='" + textBox2.Text+"'";
            string Status = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 3);
            //Console.WriteLine(Status);
            if (Status == "Confirmed")  //has events
            {
                MessageBox.Show("You may only delete arenas that have no events!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else  //has no events
            {
                if (MessageBox.Show("The selected arena has no events, are you sure to delete the selected arena?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //sqlstr = "alter table arena drop constraint"+;
                    //AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    sqlstr = "delete from Arena where ArenaName='" + ArenaName + "'";
                    AccessHelper.Access_Operation.ExcuteSql(sqlstr);
                    MessageBox.Show("Arena deleted successfully!");
                    //reload previous arena infomation
                    string str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index - 1, 1);
                    textBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index - 1, 2);
                    textBox2.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index - 1, 3);
                    textBox3.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index - 1, 4);
                    textBox4.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index - 1, 5);
                    comboBox1.Text = str;
                    str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index - 1, 6);
                    textBox5.Text = str;
                    //reload dataGridView
                    AccessHelper.Access_Operation.TransferAccessToDataGridView("ARENA", dataGridView1, "ArenaName");
                    //highlight
                    dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index - 2].Cells[0];
                }

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
                
                if (Row_Index < dataGridView1.Rows.Count-1)
                {
                    Row_Index = Row_Index + 1;
                }
                //Row_Index = Row_Index + 1;
                //Console.WriteLine(Row_Index);
                string str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 1);
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 2);
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 3);
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 4);
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 5);
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 6);
                textBox5.Text = str;
                AccessHelper.Access_Operation.Access_Close();
                //highlight
                dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index-1].Cells[0];
            }
            catch
            { }
        }

        /// <summary>
        /// Previous
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)   //previous
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

                //Console.WriteLine(Row_Index);
                string str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 1);
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 2);
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 3);
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 4);
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 5);
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", Row_Index, 6);
                textBox5.Text = str;
                AccessHelper.Access_Operation.Access_Close();
                //highlight
                dataGridView1.CurrentCell = dataGridView1.Rows[Row_Index-1].Cells[0];
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

                string str = AccessHelper.Access_Operation.GetCellValue("Arena", e.RowIndex + 1, 1);
                textBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", e.RowIndex + 1, 2);
                textBox2.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", e.RowIndex + 1, 3);
                textBox3.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", e.RowIndex + 1, 4);
                textBox4.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", e.RowIndex + 1, 5);
                comboBox1.Text = str;
                str = AccessHelper.Access_Operation.GetCellValue("Arena", e.RowIndex + 1, 6);
                textBox5.Text = str;
                AccessHelper.Access_Operation.Access_Close();
            }
            catch
            { }
        }

    }
}
