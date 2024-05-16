using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            ConnectionClass cs = new ConnectionClass();
            SqlConnection Connection = new SqlConnection();
            
            Connection.ConnectionString = cs.connectionString;
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            // Use parameterized query to prevent SQL injection
            Command.CommandText = "SELECT * FROM Login WHERE Username = @Username AND Password = @Password COLLATE Latin1_General_CS_AS";

            // Add parameters to the SqlCommand
            Command.Parameters.AddWithValue("@Username", UsernameText.Text);
            Command.Parameters.AddWithValue("@Password", PasswordText.Text);

            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            if (Data.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Home_Page HP = new Home_Page();
                HP.Show();
            }
            else
            {
                MessageBox.Show("Username or Password Wrong", "Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}