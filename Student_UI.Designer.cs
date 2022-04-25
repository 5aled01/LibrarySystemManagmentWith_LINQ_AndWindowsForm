namespace Library
{
    partial class Student_UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.Label();
            this.contact_number = new System.Windows.Forms.Label();
            this.date_of_birth = new System.Windows.Forms.Label();
            this.departement = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.borrower_id = new System.Windows.Forms.Label();
            this.student_name_textBox = new System.Windows.Forms.TextBox();
            this.contact_number_textBox = new System.Windows.Forms.TextBox();
            this.borrower_id_textBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.insert_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sex_comboBox = new System.Windows.Forms.ComboBox();
            this.departement_comboBox = new System.Windows.Forms.ComboBox();
            this.Ubdate = new System.Windows.Forms.Button();
            this.student_id = new System.Windows.Forms.TextBox();
            this.bibliothequeDataSet = new Library.BibliothequeDataSet();
            this.userdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_detailsTableAdapter = new Library.BibliothequeDataSetTableAdapters.user_detailsTableAdapter();
            this.bibliothequeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_detailsTableAdapter = new Library.BibliothequeDataSetTableAdapters.book_detailsTableAdapter();
            this.search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student menager";
            // 
            // student_name
            // 
            this.student_name.AutoSize = true;
            this.student_name.Location = new System.Drawing.Point(51, 82);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(73, 13);
            this.student_name.TabIndex = 1;
            this.student_name.Text = "Student name";
            // 
            // contact_number
            // 
            this.contact_number.AutoSize = true;
            this.contact_number.Location = new System.Drawing.Point(51, 112);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(82, 13);
            this.contact_number.TabIndex = 2;
            this.contact_number.Text = "Contact number";
            // 
            // date_of_birth
            // 
            this.date_of_birth.AutoSize = true;
            this.date_of_birth.Location = new System.Drawing.Point(51, 150);
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.Size = new System.Drawing.Size(65, 13);
            this.date_of_birth.TabIndex = 3;
            this.date_of_birth.Text = "Date of birth";
            // 
            // departement
            // 
            this.departement.AutoSize = true;
            this.departement.Location = new System.Drawing.Point(374, 82);
            this.departement.Name = "departement";
            this.departement.Size = new System.Drawing.Size(68, 13);
            this.departement.TabIndex = 4;
            this.departement.Text = "Departement";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(374, 112);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(25, 13);
            this.sex.TabIndex = 5;
            this.sex.Text = "Sex";
            // 
            // borrower_id
            // 
            this.borrower_id.AutoSize = true;
            this.borrower_id.Location = new System.Drawing.Point(374, 150);
            this.borrower_id.Name = "borrower_id";
            this.borrower_id.Size = new System.Drawing.Size(60, 13);
            this.borrower_id.TabIndex = 6;
            this.borrower_id.Text = "Borrower id";
            // 
            // student_name_textBox
            // 
            this.student_name_textBox.Location = new System.Drawing.Point(164, 82);
            this.student_name_textBox.Name = "student_name_textBox";
            this.student_name_textBox.Size = new System.Drawing.Size(100, 20);
            this.student_name_textBox.TabIndex = 8;
            // 
            // contact_number_textBox
            // 
            this.contact_number_textBox.Location = new System.Drawing.Point(164, 112);
            this.contact_number_textBox.Name = "contact_number_textBox";
            this.contact_number_textBox.Size = new System.Drawing.Size(100, 20);
            this.contact_number_textBox.TabIndex = 9;
            // 
            // borrower_id_textBox
            // 
            this.borrower_id_textBox.Location = new System.Drawing.Point(474, 150);
            this.borrower_id_textBox.Name = "borrower_id_textBox";
            this.borrower_id_textBox.Size = new System.Drawing.Size(100, 20);
            this.borrower_id_textBox.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(137, 150);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(104, 213);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 16;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sex_comboBox
            // 
            this.sex_comboBox.FormattingEnabled = true;
            this.sex_comboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.sex_comboBox.Location = new System.Drawing.Point(474, 109);
            this.sex_comboBox.Name = "sex_comboBox";
            this.sex_comboBox.Size = new System.Drawing.Size(121, 21);
            this.sex_comboBox.TabIndex = 18;
            // 
            // departement_comboBox
            // 
            this.departement_comboBox.FormattingEnabled = true;
            this.departement_comboBox.Items.AddRange(new object[] {
            "Informatique",
            "Club"});
            this.departement_comboBox.Location = new System.Drawing.Point(474, 74);
            this.departement_comboBox.Name = "departement_comboBox";
            this.departement_comboBox.Size = new System.Drawing.Size(121, 21);
            this.departement_comboBox.TabIndex = 19;
            // 
            // Ubdate
            // 
            this.Ubdate.Location = new System.Drawing.Point(207, 213);
            this.Ubdate.Name = "Ubdate";
            this.Ubdate.Size = new System.Drawing.Size(75, 23);
            this.Ubdate.TabIndex = 20;
            this.Ubdate.Text = "Ubdate";
            this.Ubdate.UseVisualStyleBackColor = true;
            this.Ubdate.Click += new System.EventHandler(this.Ubdate_Click);
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(474, 252);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(100, 20);
            this.student_id.TabIndex = 21;
            this.student_id.Visible = false;
            // 
            // bibliothequeDataSet
            // 
            this.bibliothequeDataSet.DataSetName = "BibliothequeDataSet";
            this.bibliothequeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userdetailsBindingSource
            // 
            this.userdetailsBindingSource.DataMember = "user_details";
            this.userdetailsBindingSource.DataSource = this.bibliothequeDataSet;
            // 
            // user_detailsTableAdapter
            // 
            this.user_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // bibliothequeDataSetBindingSource
            // 
            this.bibliothequeDataSetBindingSource.DataSource = this.bibliothequeDataSet;
            this.bibliothequeDataSetBindingSource.Position = 0;
            // 
            // bookdetailsBindingSource
            // 
            this.bookdetailsBindingSource.DataMember = "book_details";
            this.bookdetailsBindingSource.DataSource = this.bibliothequeDataSetBindingSource;
            // 
            // book_detailsTableAdapter
            // 
            this.book_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(592, 148);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 22;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(324, 213);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 23;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Student_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.Ubdate);
            this.Controls.Add(this.departement_comboBox);
            this.Controls.Add(this.sex_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.borrower_id_textBox);
            this.Controls.Add(this.contact_number_textBox);
            this.Controls.Add(this.student_name_textBox);
            this.Controls.Add(this.borrower_id);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.departement);
            this.Controls.Add(this.date_of_birth);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.label1);
            this.Name = "Student_UI";
            this.Text = "Student UI";
            this.Load += new System.EventHandler(this.Student_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliothequeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookdetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label student_name;
        private System.Windows.Forms.Label contact_number;
        private System.Windows.Forms.Label date_of_birth;
        private System.Windows.Forms.Label departement;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label borrower_id;
        private System.Windows.Forms.TextBox student_name_textBox;
        private System.Windows.Forms.TextBox contact_number_textBox;
        private System.Windows.Forms.TextBox borrower_id_textBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox sex_comboBox;
        private System.Windows.Forms.ComboBox departement_comboBox;
        private System.Windows.Forms.Button Ubdate;
        private System.Windows.Forms.TextBox student_id;
        private BibliothequeDataSet bibliothequeDataSet;
        private System.Windows.Forms.BindingSource userdetailsBindingSource;
        private BibliothequeDataSetTableAdapters.user_detailsTableAdapter user_detailsTableAdapter;
        private System.Windows.Forms.BindingSource bibliothequeDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookdetailsBindingSource;
        private BibliothequeDataSetTableAdapters.book_detailsTableAdapter book_detailsTableAdapter;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Delete;
    }
}