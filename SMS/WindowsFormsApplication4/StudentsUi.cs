using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4.Models;
using System.Data.SqlClient;

namespace WindowsFormsApplication4
{
    public partial class StudentsUi : Form
    {
        private string Conectinostring = @"Server=.\SQLEXPRESS; Database = StudenDb;Integrated Security=true";
        private SqlConnection sqlConnection;
        private Student student = new Student();

        public StudentsUi()
        {
            InitializeComponent();
            depatmentComboBox.DataSource = GetDepatmentCombo();
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            student.Name = nametextBox1.Text;
            student.Address = addresstextBox2.Text;
            student.Contact = contactextBox3.Text;
            student.RegNo = addresstextBox2.Text;
            student.DepartmentId = Convert.ToInt32(depatmentComboBox.SelectedValue);
            if (Add(student))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }

        public bool Add(Student student)
        {
            bool checker = false;

            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"insert into Students(Name,Address,ContactNo,RegNo,DepartmentId)values('" + student.Name +
                               "','" +
                               student.Address + "','" + student.Contact + "','" + student.RegNo + "'," +
                               student.DepartmentId + ")";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {

                    checker = true;
                }
                else
                {
                    checker = false;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }

            return checker;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DataTable dataTable = GetAll();
            dataGridView.DataSource = dataTable;
        }

        private DataTable GetAll()
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"Select * from Students";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            
                sqlDataAdapter.Fill(dataTable);

                //if(String.IsNullOrEmpty(dataTable))
                
                sqlConnection.Close();
            }


            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return dataTable;

        }

        private DataTable GetDepatmentCombo()
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"Select ID, Name from Departments";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }


            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;

        }

        private DataTable GetStudentCombo( Student student)
        {
            DataTable dataTable = new DataTable();
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"Select ID, Name from Students Where DepartmentId = '"+ student.DepartmentId +"'";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();
            }


            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;

        }


        private void Update_Click(object sender, EventArgs e)
        {
            student.Name = nametextBox1.Text;
            student.Address = addresstextBox2.Text;
            student.Contact = contactextBox3.Text;
            student.RegNo = addresstextBox2.Text;
            student.DepartmentId = Convert.ToInt32(depatmentComboBox.SelectedValue);
            student.ID = Convert.ToInt32(indexTextbox.Text);

            if (updatereturn(student))
            {
                MessageBox.Show("Update");
            }
            else
            {
                MessageBox.Show("Not Update");
            }

        }

        public bool updatereturn(Student student)
        {
            bool checker = false;
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"update students set Name = '" + student.Name + "',Address='" + student.Address +
                               "',Contact='" + student.Contact + "',RegNo='" + student.RegNo + "',DepartmentId=" +
                               student.DepartmentId + " where ID = " + student.ID + "";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {
                    //show();
                    checker = true;
                }
                else
                {
                    checker = false;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return checker;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            student.ID = Convert.ToInt32(indexTextbox.Text);

            if (dlt(student))
            {
                MessageBox.Show("Delete");
            }
            else
            {
                MessageBox.Show("Not Delete");
            }
            
        }

        public bool dlt(Student student)
        {
            bool checker = false;
            try
            {

                sqlConnection = new SqlConnection(Conectinostring);
                string query = @"delete from Students  where ID = " + student.ID + "";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                int ext = sqlCommand.ExecuteNonQuery();
                if (ext > 0)
                {
                    //show();
                    checker = true;
                }
                else
                {
                    checker = false;
                }
                sqlConnection.Close();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            return checker;
        }

        private void depatmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            student.DepartmentId = Convert.ToInt32(depatmentComboBox.SelectedValue);
            studentComboBox.DataSource = GetStudentCombo(student);
        }













        private void StudentsUi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studenDbDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.studenDbDataSet.Departments);
            

        }



    
    }
}
