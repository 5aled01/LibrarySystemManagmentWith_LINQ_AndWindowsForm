using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Library_main_UI : Form
    {
        public Library_main_UI()
        {
            InitializeComponent();
            loadData();
        }

        DataClasses1DataContext context = new DataClasses1DataContext();

        private void studentMenagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void studentManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_UI Student_manager = new Student_UI();

            Student_manager.Show();
        }

        private void Library_main_UI_Load(object sender, EventArgs e)
        {

        }

   

        void loadData()
        {
            var st = from s in context.borrower_details select new { s.id_book, s.borrowed_from, s.borrowed_to, s.returned, s.borrower_id };
            dataGridView1.DataSource = st;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
          //  borrower_details.id_book = dataGridView1.CurrentRow.Cells[0].Value.ToString();
      
        }

        private void SelectById_Click(object sender, EventArgs e)
        {

        }

        private void bookManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book Book_UI = new Book();

            Book_UI.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            
            int borrower_id = int.Parse(borrowerIdTextBox.Text);
            int book_id = int.Parse(bookIdTextBox.Text);
            DateTime borrowed_from = DateTime.Parse(FromTimePicker.Text);
            DateTime borrowed_to = DateTime.Parse(ToTimePicker.Text);

            var st = new borrower_detail
            {
                id_book = book_id,
                borrowed_from = borrowed_from,
                borrowed_to = borrowed_to,
                returned = "NO",
                borrower_id = borrower_id,
            };

            context.borrower_details.InsertOnSubmit(st);
            context.SubmitChanges();
            MessageBox.Show("Successfully Inserted bro");
            loadData();
        }
            catch (Exception ex)
            {
                MessageBox.Show("collone vide ou (borrower id)/(book id) nexist pas , eseyer de remplire tout les colone correctement");
            }
    

}
    }

