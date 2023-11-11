namespace SE_Projext.Forms
{
    partial class addTask
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
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionText
            // 
            this.DescriptionText.BackColor = System.Drawing.SystemColors.Menu;
            this.DescriptionText.Location = new System.Drawing.Point(108, 13);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(147, 57);
            this.DescriptionText.TabIndex = 29;
            this.DescriptionText.TextChanged += new System.EventHandler(this.DescriptionText_TextChanged);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Update,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 289);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridView1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 158);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(794, 289);
            this.panel8.TabIndex = 2;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(227, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 1);
            this.panel3.TabIndex = 32;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DescriptionText);
            this.panel7.Controls.Add(this.txtDescription);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(529, 8);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 97);
            this.panel7.TabIndex = 31;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDescription.Location = new System.Drawing.Point(10, 13);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.Text = "Description";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.Location = new System.Drawing.Point(440, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.NameText);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(227, 8);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(296, 97);
            this.panel6.TabIndex = 30;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.SystemColors.Menu;
            this.NameText.Location = new System.Drawing.Point(95, 52);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 28;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tite";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "DeadLine";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 97);
            this.panel5.TabIndex = 29;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(-4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Project";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(529, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 1);
            this.panel4.TabIndex = 28;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 1);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.63261F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.36739F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.369128F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.63087F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 108);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tableLayoutPanel2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(794, 108);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 16;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel3.Controls.Add(this.btnBack, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 117);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 35);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAdd.Location = new System.Drawing.Point(558, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "addTask";
            this.Text = "Task";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}