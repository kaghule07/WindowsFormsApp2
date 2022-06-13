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
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form4()
        {
            InitializeComponent();
            string strcn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strcn);
        }
        private DataSet GetCourseData()
        {
            da = new SqlDataAdapter("select * from Course", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Course"); 
            return ds;
        }
        private void btn2save_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetCourseData();
                DataRow row = ds.Tables["Course"].NewRow();
                row["Id"] = textBox1Id.Text;
                row["Name"] = textBox2Name.Text;
                row["Fees"] = textBox3Fees.Text;
                ds.Tables["Course"].Rows.Add(row);
                int result = da.Update(ds.Tables["Course"]);
                if (result == 1)
                    MessageBox.Show("Record Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn3update_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetCourseData();
                DataRow row = ds.Tables["Course"].Rows.Find(textBox1Id.Text);
                if (row != null)
                {
                    row["Name"] = textBox2Name.Text;
                    row["Fees"] = textBox3Fees.Text;
                    int result = da.Update(ds.Tables["Course"]);
                    if (result == 1)
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
                ds = GetCourseData();
                DataRow row = ds.Tables["Course"].Rows.Find(textBox1Id.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["Course"]);
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
                ds = GetCourseData();
                DataRow row = ds.Tables["Course"].Rows.Find(textBox1Id.Text);
                if (row != null)
                {
                    textBox2Name.Text = row["Name"].ToString();
                    textBox3Fees.Text = row["Fees"].ToString();
                    int result = da.Update(ds.Tables["Course"]);
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

        private void btnShowAllCr_Click(object sender, EventArgs e)
        {
            ds = GetCourseData();
            AllCourseView.DataSource = ds.Tables["Course"];
        }
    }
    
}
