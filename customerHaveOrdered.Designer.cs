
namespace UASSEM1
{
    partial class customerHaveOrdered
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.servedtoclear = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.notab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.totprice = new System.Windows.Forms.TextBox();
            this.totpricetext = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(30, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 449);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1129, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowDefaultCellStyleChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowDefaultCellStyleChanged);
            // 
            // chk
            // 
            this.chk.HeaderText = "Select";
            this.chk.MinimumWidth = 8;
            this.chk.Name = "chk";
            this.chk.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.time);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 121);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(984, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date and Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Orders";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(973, 82);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(258, 19);
            this.time.TabIndex = 33;
            // 
            // servedtoclear
            // 
            this.servedtoclear.BackColor = System.Drawing.Color.LimeGreen;
            this.servedtoclear.FlatAppearance.BorderSize = 0;
            this.servedtoclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servedtoclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servedtoclear.ForeColor = System.Drawing.Color.White;
            this.servedtoclear.Location = new System.Drawing.Point(1035, 684);
            this.servedtoclear.Name = "servedtoclear";
            this.servedtoclear.Size = new System.Drawing.Size(140, 56);
            this.servedtoclear.TabIndex = 2;
            this.servedtoclear.Text = "Bill";
            this.servedtoclear.UseVisualStyleBackColor = false;
            this.servedtoclear.Click += new System.EventHandler(this.servedtoclear_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGray;
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(12, 744);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "back";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // notab
            // 
            this.notab.FormattingEnabled = true;
            this.notab.Location = new System.Drawing.Point(116, 167);
            this.notab.Name = "notab";
            this.notab.Size = new System.Drawing.Size(140, 28);
            this.notab.TabIndex = 28;
            this.notab.SelectedIndexChanged += new System.EventHandler(this.notab_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "No. Table";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(62)))), ((int)(((byte)(47)))));
            this.panel3.Location = new System.Drawing.Point(30, 676);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 18);
            this.panel3.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 675);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Already Paid";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(880, 163);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1044, 163);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 26);
            this.dateTimePicker2.TabIndex = 34;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 676);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Haven\'t paid";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(158, 677);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 18);
            this.panel4.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1022, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(876, 684);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 56);
            this.button1.TabIndex = 37;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totprice
            // 
            this.totprice.Location = new System.Drawing.Point(567, 684);
            this.totprice.Name = "totprice";
            this.totprice.ReadOnly = true;
            this.totprice.Size = new System.Drawing.Size(208, 26);
            this.totprice.TabIndex = 39;
            // 
            // totpricetext
            // 
            this.totpricetext.AutoSize = true;
            this.totpricetext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totpricetext.Location = new System.Drawing.Point(474, 685);
            this.totpricetext.Name = "totpricetext";
            this.totpricetext.Size = new System.Drawing.Size(72, 25);
            this.totpricetext.TabIndex = 38;
            this.totpricetext.Text = "Total : ";
            // 
            // customerHaveOrdered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1220, 805);
            this.Controls.Add(this.totprice);
            this.Controls.Add(this.totpricetext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.notab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.servedtoclear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "customerHaveOrdered";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.customerHaveOrdered_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button servedtoclear;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox notab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox totprice;
        private System.Windows.Forms.Label totpricetext;
    }
}