namespace ESportsEvents
{
    partial class Frm_EventMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_Arena = new System.Windows.Forms.Panel();
            this.cbo_ArenaName = new System.Windows.Forms.ComboBox();
            this.aRENABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nZESLDataSet1 = new ESportsEvents.NZESLDataSet();
            this.cbo_ArenaID = new System.Windows.Forms.ComboBox();
            this.lbl_Arena = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aRENATableAdapter1 = new ESportsEvents.NZESLDataSetTableAdapters.ARENATableAdapter();
            this.groupBox1.SuspendLayout();
            this.pnl_Arena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRENABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nZESLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 31);
            this.button3.TabIndex = 12;
            this.button3.Text = "Add Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(403, 331);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Update Event";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(546, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 31);
            this.button5.TabIndex = 14;
            this.button5.Text = "Delete Event";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(545, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 31);
            this.button6.TabIndex = 15;
            this.button6.Text = "Return";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnl_Arena);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(276, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 299);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // pnl_Arena
            // 
            this.pnl_Arena.Controls.Add(this.cbo_ArenaName);
            this.pnl_Arena.Controls.Add(this.cbo_ArenaID);
            this.pnl_Arena.Controls.Add(this.lbl_Arena);
            this.pnl_Arena.Location = new System.Drawing.Point(19, 79);
            this.pnl_Arena.Name = "pnl_Arena";
            this.pnl_Arena.Size = new System.Drawing.Size(352, 58);
            this.pnl_Arena.TabIndex = 27;
            // 
            // cbo_ArenaName
            // 
            this.cbo_ArenaName.DataSource = this.aRENABindingSource;
            this.cbo_ArenaName.DisplayMember = "ArenaName";
            this.cbo_ArenaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ArenaName.FormattingEnabled = true;
            this.cbo_ArenaName.Location = new System.Drawing.Point(187, 18);
            this.cbo_ArenaName.Name = "cbo_ArenaName";
            this.cbo_ArenaName.Size = new System.Drawing.Size(145, 22);
            this.cbo_ArenaName.TabIndex = 2;
            this.cbo_ArenaName.ValueMember = "ArenaName";
            // 
            // aRENABindingSource
            // 
            this.aRENABindingSource.DataMember = "ARENA";
            this.aRENABindingSource.DataSource = this.nZESLDataSet1;
            // 
            // nZESLDataSet1
            // 
            this.nZESLDataSet1.DataSetName = "NZESLDataSet";
            this.nZESLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbo_ArenaID
            // 
            this.cbo_ArenaID.DataSource = this.aRENABindingSource;
            this.cbo_ArenaID.DisplayMember = "ArenaID";
            this.cbo_ArenaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ArenaID.FormattingEnabled = true;
            this.cbo_ArenaID.Location = new System.Drawing.Point(111, 18);
            this.cbo_ArenaID.Name = "cbo_ArenaID";
            this.cbo_ArenaID.Size = new System.Drawing.Size(61, 22);
            this.cbo_ArenaID.TabIndex = 1;
            this.cbo_ArenaID.ValueMember = "ArenaID";
            // 
            // lbl_Arena
            // 
            this.lbl_Arena.AutoSize = true;
            this.lbl_Arena.Location = new System.Drawing.Point(57, 21);
            this.lbl_Arena.Name = "lbl_Arena";
            this.lbl_Arena.Size = new System.Drawing.Size(49, 14);
            this.lbl_Arena.TabIndex = 0;
            this.lbl_Arena.Text = "Arena:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 174);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 23);
            this.numericUpDown1.TabIndex = 26;
            this.numericUpDown1.Value = new decimal(new int[] {
            101,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Confirmed",
            "Unconfirmed",
            "Cancelled"});
            this.comboBox1.Location = new System.Drawing.Point(131, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 22);
            this.comboBox1.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 14);
            this.label7.TabIndex = 23;
            this.label7.Text = "Event Date:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(130, 51);
            this.textBox6.MaxLength = 40;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(221, 23);
            this.textBox6.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 21;
            this.label6.Text = "Event Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Location = new System.Drawing.Point(6, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 40);
            this.panel1.TabIndex = 20;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(253, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 31);
            this.button7.TabIndex = 19;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(13, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 31);
            this.button8.TabIndex = 18;
            this.button8.Text = "Save Event";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 23);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 23);
            this.textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 23);
            this.textBox1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Capacity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Arena Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Arena ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Event ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(243, 299);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // aRENATableAdapter1
            // 
            this.aRENATableAdapter1.ClearBeforeFill = true;
            // 
            // Frm_EventMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Frm_EventMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Maintenance";
            this.Load += new System.EventHandler(this.Frm_EventMaintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_Arena.ResumeLayout(false);
            this.pnl_Arena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRENABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nZESLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnl_Arena;
        private System.Windows.Forms.ComboBox cbo_ArenaName;
        private System.Windows.Forms.ComboBox cbo_ArenaID;
        private System.Windows.Forms.Label lbl_Arena;
        private NZESLDataSet nZESLDataSet;
        private NZESLDataSetTableAdapters.ARENATableAdapter aRENATableAdapter;
        private NZESLDataSet nZESLDataSet1;
        private System.Windows.Forms.BindingSource aRENABindingSource;
        private NZESLDataSetTableAdapters.ARENATableAdapter aRENATableAdapter1;
    }
}