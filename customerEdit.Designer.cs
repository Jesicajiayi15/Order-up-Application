
namespace UASSEM1
{
    partial class customerEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.nameedit = new System.Windows.Forms.TextBox();
            this.totalpricebfraddtxt = new System.Windows.Forms.Label();
            this.totalpricebfraddedit = new System.Windows.Forms.TextBox();
            this.pricela = new System.Windows.Forms.Label();
            this.priceedit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.commentedit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.TextBox();
            this.editbut = new System.Windows.Forms.Button();
            this.canbutt = new System.Windows.Forms.Button();
            this.qtyedit = new System.Windows.Forms.TextBox();
            this.notabedit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchbar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameedit
            // 
            this.nameedit.Location = new System.Drawing.Point(38, 184);
            this.nameedit.Multiline = true;
            this.nameedit.Name = "nameedit";
            this.nameedit.ReadOnly = true;
            this.nameedit.Size = new System.Drawing.Size(142, 168);
            this.nameedit.TabIndex = 1;
            // 
            // totalpricebfraddtxt
            // 
            this.totalpricebfraddtxt.AutoSize = true;
            this.totalpricebfraddtxt.Location = new System.Drawing.Point(201, 303);
            this.totalpricebfraddtxt.Name = "totalpricebfraddtxt";
            this.totalpricebfraddtxt.Size = new System.Drawing.Size(83, 20);
            this.totalpricebfraddtxt.TabIndex = 36;
            this.totalpricebfraddtxt.Text = "Total Price";
            // 
            // totalpricebfraddedit
            // 
            this.totalpricebfraddedit.Location = new System.Drawing.Point(205, 326);
            this.totalpricebfraddedit.Name = "totalpricebfraddedit";
            this.totalpricebfraddedit.ReadOnly = true;
            this.totalpricebfraddedit.Size = new System.Drawing.Size(279, 26);
            this.totalpricebfraddedit.TabIndex = 35;
            // 
            // pricela
            // 
            this.pricela.AutoSize = true;
            this.pricela.Location = new System.Drawing.Point(201, 161);
            this.pricela.Name = "pricela";
            this.pricela.Size = new System.Drawing.Size(44, 20);
            this.pricela.TabIndex = 34;
            this.pricela.Text = "Price";
            // 
            // priceedit
            // 
            this.priceedit.Location = new System.Drawing.Point(205, 184);
            this.priceedit.Name = "priceedit";
            this.priceedit.ReadOnly = true;
            this.priceedit.Size = new System.Drawing.Size(142, 26);
            this.priceedit.TabIndex = 33;
            this.priceedit.TextChanged += new System.EventHandler(this.priceedit_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Qty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Comment";
            // 
            // commentedit
            // 
            this.commentedit.ForeColor = System.Drawing.Color.Gray;
            this.commentedit.Location = new System.Drawing.Point(38, 403);
            this.commentedit.Multiline = true;
            this.commentedit.Name = "commentedit";
            this.commentedit.Size = new System.Drawing.Size(446, 168);
            this.commentedit.TabIndex = 29;
            this.commentedit.Text = "Comment here for the specification of your order";
            this.commentedit.TextChanged += new System.EventHandler(this.commentedit_TextChanged);
            this.commentedit.Enter += new System.EventHandler(this.commentedit_Enter);
            this.commentedit.Leave += new System.EventHandler(this.commentedit_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.time);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 104);
            this.panel1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(813, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 53);
            this.label2.TabIndex = 38;
            this.label2.Text = "Edit Order";
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(983, 51);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(195, 26);
            this.time.TabIndex = 48;
            this.time.TextChanged += new System.EventHandler(this.time_TextChanged);
            // 
            // editbut
            // 
            this.editbut.BackColor = System.Drawing.Color.ForestGreen;
            this.editbut.FlatAppearance.BorderSize = 0;
            this.editbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbut.ForeColor = System.Drawing.Color.White;
            this.editbut.Location = new System.Drawing.Point(38, 628);
            this.editbut.Name = "editbut";
            this.editbut.Size = new System.Drawing.Size(122, 54);
            this.editbut.TabIndex = 39;
            this.editbut.Text = "Update";
            this.editbut.UseVisualStyleBackColor = false;
            this.editbut.Click += new System.EventHandler(this.editbut_Click);
            // 
            // canbutt
            // 
            this.canbutt.BackColor = System.Drawing.Color.Brown;
            this.canbutt.FlatAppearance.BorderSize = 0;
            this.canbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canbutt.ForeColor = System.Drawing.Color.White;
            this.canbutt.Location = new System.Drawing.Point(362, 628);
            this.canbutt.Name = "canbutt";
            this.canbutt.Size = new System.Drawing.Size(122, 54);
            this.canbutt.TabIndex = 38;
            this.canbutt.Text = "Cancel";
            this.canbutt.UseVisualStyleBackColor = false;
            this.canbutt.Click += new System.EventHandler(this.canbutt_Click);
            // 
            // qtyedit
            // 
            this.qtyedit.Location = new System.Drawing.Point(377, 184);
            this.qtyedit.Name = "qtyedit";
            this.qtyedit.Size = new System.Drawing.Size(107, 26);
            this.qtyedit.TabIndex = 40;
            this.qtyedit.TextChanged += new System.EventHandler(this.qtyedit_TextChanged);
            this.qtyedit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtyedit_KeyPress);
            // 
            // notabedit
            // 
            this.notabedit.FormattingEnabled = true;
            this.notabedit.Location = new System.Drawing.Point(205, 261);
            this.notabedit.Name = "notabedit";
            this.notabedit.Size = new System.Drawing.Size(140, 28);
            this.notabedit.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = "No. Table";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(550, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 448);
            this.panel2.TabIndex = 48;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(15, 15);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(600, 421);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // catg
            // 
            this.catg.FormattingEnabled = true;
            this.catg.Location = new System.Drawing.Point(1023, 152);
            this.catg.Name = "catg";
            this.catg.Size = new System.Drawing.Size(155, 28);
            this.catg.TabIndex = 52;
            this.catg.SelectedIndexChanged += new System.EventHandler(this.catg_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(926, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Search";
            // 
            // searchbar
            // 
            this.searchbar.Location = new System.Drawing.Point(614, 158);
            this.searchbar.Name = "searchbar";
            this.searchbar.Size = new System.Drawing.Size(224, 26);
            this.searchbar.TabIndex = 49;
            this.searchbar.TextChanged += new System.EventHandler(this.searchbar_TextChanged_1);
            // 
            // customerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1213, 751);
            this.Controls.Add(this.catg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchbar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.notabedit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.qtyedit);
            this.Controls.Add(this.editbut);
            this.Controls.Add(this.canbutt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalpricebfraddtxt);
            this.Controls.Add(this.totalpricebfraddedit);
            this.Controls.Add(this.pricela);
            this.Controls.Add(this.priceedit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commentedit);
            this.Controls.Add(this.nameedit);
            this.Controls.Add(this.label1);
            this.Name = "customerEdit";
            this.Text = "Edit Order";
            this.Load += new System.EventHandler(this.customerEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalpricebfraddtxt;
        private System.Windows.Forms.Label pricela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editbut;
        private System.Windows.Forms.Button canbutt;
        public System.Windows.Forms.TextBox nameedit;
        public System.Windows.Forms.TextBox totalpricebfraddedit;
        public System.Windows.Forms.TextBox priceedit;
        public System.Windows.Forms.TextBox commentedit;
        public System.Windows.Forms.TextBox qtyedit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox notabedit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox catg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchbar;
    }
}