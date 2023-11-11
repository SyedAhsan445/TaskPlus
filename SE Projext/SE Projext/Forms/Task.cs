using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_Projext.Forms
{
    public partial class addTask : Form
    {
        public addTask()
        {
            InitializeComponent();
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select ProjectID from Project", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    comboBox1.Items.Add(row["ProjectID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
               
            }
        }
        private int getCurrentUser()
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 UserID FROM HistoryLogin ORDER BY LoginID DESC", con);

            // Use ExecuteScalar to get the UserID
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                int userId = Convert.ToInt32(result);
                MessageBox.Show("Login successful. UserID: " + userId);
                return userId;
            }
            else
            {
                return 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FindProjectName(comboBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (NameText.Text == "" || DescriptionText.Text == "")
                {
                    MessageBox.Show("Fields can not be Emty !");
                }
                else
                {


                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Task values( 1,@PID, @Title, @Description,@CreatedDate,@DeadLine )", con);//(Select Max (ProjectID) from Project)+
                    cmd.Parameters.AddWithValue("@PID", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Title", NameText.Text);

                    cmd.Parameters.AddWithValue("@Description", DescriptionText.Text);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@DeadLine", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    reload();




                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                // If Track and source needed
                //+ "\n\nException Source: " +ex.Source + "\n\nException Stack Trace:"+ ex.StackTrace
            }
        }
        private void reload()
        {

            //// To Reload
            //var con1 = Configuration.getInstance().getConnection();
            //SqlCommand cmd1 = new SqlCommand("Select * from Task ", con1);
            //SqlDataAdapter da = new SqlDataAdapter(cmd1);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
        public void FindProjectName(String Id)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("Select ProjectName from Project WHERE ProjectID = @Id", con);
            //cmd.Parameters.AddWithValue("@Id", Id);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //textBox1.Text = dt.Rows[0]["ProjectName"].ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
