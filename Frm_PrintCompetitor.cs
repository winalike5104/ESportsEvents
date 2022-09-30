using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESportsEvents
{
    public partial class Frm_PrintCompetitor : Form
    {
        private static string filepath = @"c:\temp\NZESL.mdb";

        public Frm_PrintCompetitor()
        {
            InitializeComponent();
        }

        List<string> PrintInfos = new List<string>();
        List<string> PrintInfos2 = new List<string>();
        List<string> has_EntryList = new List<string>();
        int Fcount = 0;

        private void InitInfo()
        {
            PrinterSettings printSetting = new PrinterSettings();
            printSetting.PrintRange = PrintRange.AllPages;

            int width = 600;
            int height = 400;
            PageSettings pageSetting = new PageSettings(printSetting);
            pageSetting.PaperSize = new PaperSize("customer", width, height);

            int margin_lr = 2;
            int margin_tb = 2;
            pageSetting.Margins = new Margins(margin_lr, margin_lr, margin_tb, margin_tb);
            this.printDocument1.DefaultPageSettings = pageSetting;
        }


        /// <summary>
        /// Fill the background with color
        /// </summary>  
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdControl_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Console.WriteLine("calling");
            Graphics g = e.Graphics;
            g.PageScale = 1;
            g.PageUnit = GraphicsUnit.Millimeter;
            Font tFont = new Font("Arial", 15, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            int Lcount = has_EntryList.Count;
            g.DrawString(PrintInfos[Fcount], tFont, b, new Point(10, 10));
            g.DrawString(PrintInfos2[Fcount], tFont, b, new Point(10, 75));

            Fcount += 1;
            if (Fcount < Lcount)
            {
                //Console.WriteLine(Fcount);
                e.HasMorePages = true;
            }

        }

        /// <summary>
        /// Print competitor
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AccessHelper.Access_Operation.Access_Open(filepath);
            List<string> CompList = new List<string>();
            List<string> EntryList = new List<string>();
            
            
            CompList = AccessHelper.Access_Operation.GetTableFieldValueList(@"Competitor", "CompetitorID");
            EntryList = AccessHelper.Access_Operation.GetTableFieldValueList(@"Entry", "ChallengeID");
            foreach (string i in CompList)
            {
                string sqlstr = "select Entry.CompetitorID from Entry where [Entry.CompetitorID]=" + i;
                //Console.WriteLine(str);
                try
                {
                    string has_entry = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 1);


                    //Console.WriteLine(has_entry);
                    if (has_entry == "")
                    {
                        continue;
                    }
                    else
                    {
                        has_EntryList.Add(i);
                        //Console.WriteLine(i);
                    }
                }
                catch { }
            }
            //Console.WriteLine(has_EntryList);
            int Lcount = has_EntryList.Count;

            foreach (string i in has_EntryList)
            {

                //Console.WriteLine("foreach" + i);
                string sqlstr = "select * from Competitor where CompetitorID=" + i;
                string Str_CompID = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 1);
                string Str_UserName = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 2);
                string Str_FullName = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 7) + AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 3);
                string Str_Gender = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 4);
                string Str_DoB = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 5);
                string Str_Email = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 6);
                string content = "CompetitorpID:" + Str_CompID + "\n\nUsername: " + Str_UserName + "\nName: " + Str_FullName + "\nGender:   " + Str_Gender + "\nDate of Birth:  " + Str_DoB + "\nEmail: " + Str_Email + "\n\nEntries:" + "\nChallenge ID    Challenge Name          Start Time";
                PrintInfos.Add(content);

            }
            foreach (string entry in has_EntryList)
            {
                string sqlstr = "select * from Entry where CompetitorID=" + entry;
                string Str_ChaID = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr, 1);
                //Console.WriteLine(sqlstr2);
                string sqlstrC = "select * from Challenge where ChallengeID=" + Str_ChaID;
                string Str_ChaName = AccessHelper.Access_Operation.GetCellValuebySql(sqlstrC, 2);
                string Str_Time = AccessHelper.Access_Operation.GetCellValuebySql(sqlstrC, 4);
                
                string time = string.Format("{0:t}", Convert.ToDateTime(Str_Time));
                //Console.WriteLine(entry + "ID:" + Str_ChaID);
                string content = Str_ChaID + "                         " + Str_ChaName + "                     " + time;
                PrintInfos2.Add(content);
            }

            AccessHelper.Access_Operation.Access_Close();
            //printPreviewDialog1.Document = printDocument1; //printview
            this.printPreviewDialog1.Show();
            Frm_PrintCompetitor PrinVac = new Frm_PrintCompetitor();
            PrinVac.Show();
            this.Close();

        }


        /// <summary>
        /// return main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MainM = new MainMenu();
            MainM.Show();
        }

        private void Frm_PrintCompetitor_Load(object sender, EventArgs e)
        {
            InitInfo();
        }

    }
}
