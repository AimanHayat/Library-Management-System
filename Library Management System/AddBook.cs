using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBook : UserControl
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void BookCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void BookSave_Click(object sender, EventArgs e)
        {
            if (Quantity.Text == "0")
            {
                MessageBox.Show("Please enter book quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BookName.Text != "" && ISBN.Text != "" && PublishDate.Text != "" && Category.Text != "" && Quantity.Text != "" && Quantity.Text.All(Char.IsDigit))
            {

                String Name = BookName.Text;
                String BookISBN = ISBN.Text;
                String Date = PublishDate.Text;
                String Categ = Category.Text;
                Int64 Quan = Int64.Parse(Quantity.Text);
                String Author = textBox1.Text;

                ConnectionClass cs = new ConnectionClass();
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = cs.connectionString;
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = "Select * From AddNewBook Where ISBN='" + ISBN.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count < 1)
                {
                    Connection.Open();
                    Command.CommandText = "Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity,AuthorName) Values ('" + Name + "','" + BookISBN + "','" + Date + "','" + Categ + "','" + Quan + "','" + textBox1.Text + "') ";
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BookName.Clear();
                    ISBN.Clear();
                    Category.Clear();
                    Quantity.Clear();

                 
                }
                else
                {
                    MessageBox.Show("Primary Key Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Fill Complete Information or Data Type Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BookName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
