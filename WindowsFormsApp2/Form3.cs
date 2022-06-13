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
using System.Configuration;
namespace WindowsFormsApp2
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
            string strcn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strcn);
        }

        private DataSet GetEmployeeData()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            // add PK constraint to the col (id) which is in DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // build the command for DataAdpater 
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // Fill() fire the select qry in DB & load data in DataSet
            da.Fill(ds, "Employee"); // Employee is the name given to the table which get loaded in the DataSet
            return ds;
        }

        private void btn2save_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployeeData();
                DataRow row = ds.Tables["Employee"].NewRow();
                row["Name"] = textBox2Name.Text;
                row["Salary"] = textBox3Salary.Text;
                ds.Tables["Employee"].Rows.Add(row);
                int result = da.Update(ds.Tables["Employee"]);
                if(result==1)
                    MessageBox.Show("Record Inserted");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn3update_Click(object sender, EventArgs e)
        {
            try
            {
                ds= GetEmployeeData();
                DataRow row = ds.Tables["Employee"].Rows.Find(textBox1Id.Text);
                if(row != null)
                {
                    row["Name"] = textBox2Name.Text;
                    row["Salary"] = textBox3Salary.Text;
                    int result = da.Update(ds.Tables["Employee"]);
                    if(result==1)
                    {
                        MessageBox.Show("Record Updated");
                    }
                }
                else
                    MessageBox.Show("ID does not exists to update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn5Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployeeData();
                DataRow row = ds.Tables["Employee"].Rows.Find(textBox1Id.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["Employee"]);
                    if (result == 1)
                        MessageBox.Show("Record Deleted");
                }
                else
                    MessageBox.Show("ID does not exists to update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn4search_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployeeData();
                DataRow row = ds.Tables["Employee"].Rows.Find(textBox1Id.Text);
                if (row != null)
                {
                    textBox2Name.Text=row["Name"].ToString();
                    textBox3Salary.Text = row["Salary"].ToString();
                    int result = da.Update(ds.Tables["Employee"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Record Search");
                    }
                }
                else
                    MessageBox.Show("ID does not exists to Search");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAllEmployee_Click(object sender, EventArgs e)
        {
            ds = GetEmployeeData();
            AllEmpView.DataSource = ds.Tables["Employee"];
           
        }
    }
}
