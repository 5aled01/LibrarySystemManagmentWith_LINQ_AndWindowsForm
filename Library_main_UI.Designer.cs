namespace Library
{
    partial class Library_main_UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SelectById = new System.Windows.Forms.Button();
            this.Update_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.borrowerIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentManagerToolStripMenuItem,
            this.bookManagerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentManagerToolStripMenuItem
            // 
            this.studentManagerToolStripMenuItem.Name = "studentManagerToolStripMenuItem";
            this.studentManagerToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.studentManagerToolStripMenuItem.Text = "Student manager";
            this.studentManagerToolStripMenuItem.Click += new System.EventHandler(this.studentManagerToolStripMenuItem_Click);
            // 
            // bookManagerToolStripMenuItem
            // 
            this.bookManagerToolStripMenuItem.Name = "bookManagerToolStripMenuItem";
            this.bookManagerToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.bookManagerToolStripMenuItem.Text = "Book manager";
            this.bookManagerToolStripMenuItem.Click += new System.EventHandler(this.bookManagerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id - borrower";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Returned?";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // SelectById
            // 
            this.SelectById.Location = new System.Drawing.Point(288, 62);
            this.SelectById.Name = "SelectById";
            this.SelectById.Size = new System.Drawing.Size(75, 23);
            this.SelectById.TabIndex = 9;
            this.SelectById.Text = "Search";
            this.SelectById.UseVisualStyleBackColor = true;
            this.SelectById.Click += new System.EventHandler(this.SelectById_Click);
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(288, 96);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 23);
            this.Update_button.TabIndex = 10;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox1.Location = new System.Drawing.Point(142, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(517, 174);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(141, 23);
            this.Insert.TabIndex = 14;
            this.Insert.Text = "Insert new borrower details";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.Location = new System.Drawing.Point(545, 52);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.bookIdTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "book - id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "From";
            // 
            // borrowerIdTextBox
            // 
            this.borrowerIdTextBox.Location = new System.Drawing.Point(545, 134);
            this.borrowerIdTextBox.Name = "borrowerIdTextBox";
            this.borrowerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.borrowerIdTextBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Borrowers - id";
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.Location = new System.Drawing.Point(545, 78);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromTimePicker.TabIndex = 23;
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.Location = new System.Drawing.Point(545, 108);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToTimePicker.TabIndex = 24;
            // 
            // Library_main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToTimePicker);
            this.Controls.Add(this.FromTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.borrowerIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bookIdTextBox);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.SelectById);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Library_main_UI";
            this.Text = "Library_main_UI";
            this.Load += new System.EventHandler(this.Library_main_UI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookManagerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SelectById;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borrowerIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
    }
}