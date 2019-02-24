using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string Name = nametextBox1.Text;
            string Address = addresstextBox2.Text;
            string Contact = contactextBox3.Text;
            string RegNo = regtextBox4.Text;
            int depId = Convert.ToInt32(departmenttextBox5.Text);
            try
            {
                string Conectinostring = @"Server=.\SQLEXPRESS; Database = StudentDb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(Conectinostring);
                string query = @"insert into Students(Name,Address,Contact,RegNo,DepartmentId)values('" + Name + "','" +
                               Address + "','" + Contact + "','" + RegNo + "'," + depId + ")";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {
                   
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            show();
        }
        public void show()
        {
            try
            {
                string Conectinostring = @"Server=.\SQLEXPRESS; Database = StudentDb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(Conectinostring);
                string query = @"Select * from Students";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //if(String.IsNullOrEmpty(dataTable))
                if (dataTable != null)
                {
                    dataGridView.DataSource = dataTable;
                }
                else
                {
                    dataGridView.DataSource = null;
                }
                sqlConnection.Close();
            }


            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Name = nametextBox1.Text;
            string Address = addresstextBox2.Text;
            string Contact = contactextBox3.Text;
            string RegNo = regtextBox4.Text;
            int depId = Convert.ToInt32(departmenttextBox5.Text);
            int id = Convert.ToInt32(indexTextbox.Text);

            try
            {
                string Conectinostring = @"Server=.\SQLEXPRESS; Database = StudentDb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(Conectinostring);
                string query = @"update students set Name = '" + Name + "',Address='" + Address + "',Contact='" + Contact + "',RegNo='" + RegNo + "',DepartmentId=" + depId + " where ID = " + id + "";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {
                    show();
                    MessageBox.Show("Upadate");
                }
                else
                {
                    MessageBox.Show("Not Update");
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(indexTextbox.Text);

            try
            {
                string Conectinostring = @"Server=.\SQLEXPRESS; Database = StudentDb;Integrated Security=true";
                SqlConnection sqlConnection = new SqlConnection(Conectinostring);
                string query = @"delete from Students  where ID = " + id + "";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {
                    show();
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Not Delete");
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

    }
}
