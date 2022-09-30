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
    public partial class Frm_PrintEvent : Form
    {
        private static string filepath = @"c:\temp\NZESL.mdb";

        public Frm_PrintEvent()
        {
            InitializeComponent();
        }

        List<string> PrintInfos = new List<string>();
        List<string> EventList = new List<string>();
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
        ///  Fill the background with color 
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdControl_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            g.PageScale = 1;
            g.PageUnit = GraphicsUnit.Millimeter;
            Pen lineColor = new Pen(Color.Black, 0.2f);
            Font tFont = new Font("Arial", 15, FontStyle.Regular);
            Brush b = new SolidBrush(Color.Black);
            int Lcount = EventList.Count;
            g.DrawString(PrintInfos[Fcount], tFont, b, new Point(10, 10));
            

            Fcount += 1;
            if (Fcount < Lcount)
            {
                e.HasMorePages = true;
            }

        }

        /// <summary>
        /// Print event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            AccessHelper.Access_Operation.Access_Open(filepath);



            EventList = AccessHelper.Access_Operation.GetTableFieldValueList(@"Event", "EventID");

            foreach (string i in EventList)
            {

                //Console.WriteLine("foreach" + i);
                string sqlstr_e = "select * from Event where EventID=" + i;
                string Str_EventID = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_e, 1);
                string Str_EventName = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_e, 2);
                string Str_ArenaID = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_e, 3);
                string Str_Date = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_e, 6);
                string sqlstr_a = "select * from Arena where ArenaID=" + Str_ArenaID;
                string Str_ArenaName = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_a, 2);
                string Str_Address = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_a, 3);
                string Str_Suburb = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_a, 4);
                string Str_City = AccessHelper.Access_Operation.GetCellValuebySql(sqlstr_a, 5);

                string content = "Event ID:" + Str_EventID + "\n\n" + Str_EventName + "\n" + Str_ArenaName + "\n" + Str_Address + "\n" + Str_Suburb + "\n" + Str_City + "\n\nEvent Date:" + Str_Date;
                PrintInfos.Add(content);

            }


            AccessHelper.Access_Operation.Access_Close();
            //printPreviewDialog1.Document = printDocument1; //printview
            this.printPreviewDialog1.Show();
            Frm_PrintEvent PrinCan = new Frm_PrintEvent();
            PrinCan.Show();
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

        private void Frm_PrintEvent_Load(object sender, EventArgs e)
        {
            InitInfo();
        }

    }
}
