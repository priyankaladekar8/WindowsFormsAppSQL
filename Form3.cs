using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//Disconnect architecture
namespace WindowsFormsAppSQL
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form3()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            con = new SqlConnection(constr);
        }

        private void ClearFiled()
        {
            txtid.Clear();
            tstname.Clear();
            txtcity.Clear();
            txtsalary.Clear();
        }

        //fetch data from database and load in dataset
        private DataSet GetAllEmployees()
        {

            string qry = "select * from employee";
            da = new SqlDataAdapter(qry, con);
            // add PK to the col which is in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // scb will track the DataSet & generate the qry --> assign to DataAdapter
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is the name given to the table which is in the DataSet
            // if not given then it will take default name is [0]
            //da.Fill(ds);
            da.Fill(ds, "emp");
            return ds;


    }

    private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    ds = GetAllEmployees();
                    // create new row to add record
                    DataRow row = ds.Tables["emp"].NewRow();
                    row["name"] = tstname.Text;
                    row["city"] = txtcity.Text;
                    row["salary"] = txtsalary.Text;
                    //attach row to the emp table
                    ds.Tables["emp"].Rows.Add(row);
                    int result = da.Update(ds.Tables["emp"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    tstname.Text = row["name"].ToString();
                    txtcity.Text = row["city"].ToString();
                    txtsalary.Text = row["salary"].ToString();
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
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    // override the value from textbox to row
                    row["name"] = tstname.Text;
                    row["city"] = txtcity.Text;
                    row["salary"] = txtsalary.Text;
                    int result = da.Update(ds.Tables["emp"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record updated");
                        ClearFileds();
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
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["emp"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("Record deleted");
                        ClearFileds();
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
        }

        private void btnshowemplist_Click(object sender, EventArgs e)
        {
            ds = GetAllEmployees();
            dataGridView1.DataSource = ds.Tables["emp"];
        }


        private void ClearFileds()
        {
            txtid.Clear();
            tstname.Clear();
            txtcity.Clear();
            txtsalary.Clear();
        }

    }
}
