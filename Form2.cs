using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace WindowsFormsAppSQL
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            con = new SqlConnection(constr);
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - write query
                string qry = "insert into employee values(@name,@city,@salary)";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                // fire the query
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                // step 1
                string qry = "select * from employee where id=@id";
                // step2
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                //step3 execute the qry
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // whether row is present or not
                {
                    while (dr.Read()) // read row by row -- while loop or you can use if block to read single row
                    {
                        // read column
                        txtName.Text = dr["name"].ToString();
                        txtCity.Text = dr["city"].ToString();
                        txtSalary.Text = dr["salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                // step1 - write query
                string qry = "update employee set name=@name,city=@city,salary=@salary where id=@id";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                // fire the query
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                // step1 - write query
                string qry = "delete from employee where id=@id";
                // create object of command and assign the query
                cmd = new SqlCommand(qry, con);
                // assign values to parameters
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                // fire the query
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
private void ClearFileds()
{
    txtId.Clear();
    txtName.Clear();
    txtCity.Clear();
    txtSalary.Clear();
}

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select *from employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();

                //dr hold data in the form of records(object)
                //grid needs data in table format

                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }
    }
    }

