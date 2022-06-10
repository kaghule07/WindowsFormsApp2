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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;   
        public Form1()
        {
            InitializeComponent();
            string strcn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(strcn);
        
        }

        private void btn2save_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into Employee values (@name,@salary)";
                cmd = new SqlCommand(str,con);
                //cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Id.Text));
                cmd.Parameters.AddWithValue("@name",(textBox2Name.Text));
                cmd.Parameters.AddWithValue("@salary",Convert.ToDouble(textBox3Sal.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                    MessageBox.Show("Record Inserted");
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

        private void btn3update_Click(object sender, EventArgs e)
        {

            try
            {
                string str = "update Employee set Name=@name,Salary=@salary where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Id.Text));
                cmd.Parameters.AddWithValue("@name", (textBox2Name.Text));
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBox3Sal.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Record Updated");
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

        private void btn5Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "delete from Employee where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Id.Text));
                //cmd.Parameters.AddWithValue("@name", (textBox2Name.Text));
               // cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBox3Sal.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                    MessageBox.Show("Record Deleted");
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

        private void btn4search_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Employee where Id=@id";
                cmd = new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1Id.Text));
                //cmd.Parameters.AddWithValue("@name", (textBox2Name.Text));
                // cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(textBox3Sal.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2Name.Text = dr["Name"].ToString();
                        textBox3Sal.Text = dr["Salary"].ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Record Not Found");
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

        private void btn6AllEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "select * from Employee";
                cmd = new SqlCommand(str, con);
                con.Open();
                dr = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(dr);
                AllEmpView.DataSource = table;

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
