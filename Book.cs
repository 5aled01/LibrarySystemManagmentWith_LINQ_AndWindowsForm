﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Library
{
    //Test Commit
    public partial class Book : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Book()
        {
            InitializeComponent();
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int livreid = int.Parse(livre.Text);
            string BookTitle = textBox2.Text;
            string language = textBox3.Text;
            int nbcopy = int.Parse(textBox4.Text);
            int pub_years = int.Parse(textBox5.Text);
            string Categorie = textBox6.Text;

            var st = new book_detail
            {
                id = livreid,
                book_title = BookTitle,
                language_book = language,
                no_copies = nbcopy,
                publication_year = pub_years,
                category = Categorie,
            };
            db.book_details.InsertOnSubmit(st);
            db.SubmitChanges();
            MessageBox.Show("Successfully Inserted bro");
            loadData();

        }
        void loadData()
        {
            var st = from s in db.book_details select s;
            dataGridView1.DataSource = st;
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete?", "Delete Student", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    var st = (from s in db.book_details where s.id == int.Parse(livre.Text) select s).First();
                    db.book_details.DeleteOnSubmit(st);

                    db.SubmitChanges();
                    MessageBox.Show("Student Delete sucssesfully");
                    loadData();
                }
                catch (Exception) { MessageBox.Show("Student Borrow id not valide"); }



            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                var st = from s in db.book_details where s.book_title.Contains(textBox2.Text) select s;

                dataGridView1.DataSource = st;
            }
            catch (Exception)
            {
                MessageBox.Show("BOOK id not valide");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

            int livreid = int.Parse(livre.Text);
            string BookTitle = textBox2.Text;
            string language = textBox3.Text;
            int nbcopy = int.Parse(textBox4.Text);
            int pub_years = int.Parse(textBox5.Text);
            string Categorie = textBox6.Text;

            var st = (from s in db.book_details where s.id == livreid select s).First();



            st.book_title = BookTitle;
            st.language_book = language;
            st.no_copies = nbcopy;
            st.publication_year = pub_years;
            st.category = Categorie;
            db.SubmitChanges();
            loadData();

            MessageBox.Show("Student Successfully Updated");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            livre.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            livre.Enabled = false;
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            livre.Enabled = true;
            livre.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}