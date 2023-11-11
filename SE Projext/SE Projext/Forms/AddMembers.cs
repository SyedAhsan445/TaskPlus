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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SE_Projext.Forms
{
    public partial class AddMembers : Form
    {
        public AddMembers()
        {
            InitializeComponent();
            // Load initial data when the form is created
            ReloadThings();
        }

        private void reload()
        {
            // To reload data in the DataGridView
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select * from Project_Members", con1);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if required fields are not empty
                if (UserIdCMB.Text == "" || ProjectIDCMB.Text == "")
                {
                    MessageBox.Show("Fields cannot be empty!");
                }
                else
                {
                    // Insert data into the database
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Project_Members values((Select Max(MemberID) from Project_Members)+1, @PID, @UserID, @Role, @JoinDate)", con);
                    cmd.Parameters.AddWithValue("@PID", ProjectIDCMB.Text);
                    cmd.Parameters.AddWithValue("@UserID", UserIdCMB.Text);
                    cmd.Parameters.AddWithValue("@Role", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@JoinDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");
                    // Reload data in the DataGridView
                    reload();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                // If tracking and source are needed
                // MessageBox.Show("Exception Message: " + ex.Message + "\n\nException Source: " + ex.Source + "\n\nException Stack Trace:" + ex.StackTrace);
            }
        }

        private void ReloadThings()
        {
            try
            {
                // Load ProjectIDs into the ProjectID ComboBox
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select ProjectID from Project", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProjectIDCMB.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ProjectIDCMB.Items.Add(row["ProjectID"].ToString());
                }

                // Load UserIDs into the UserId ComboBox
                var con2 = Configuration.getInstance().getConnection();
                SqlCommand cmd2 = new SqlCommand("Select UserID from Users", con2);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                foreach (DataRow row in dt2.Rows)
                {
                    UserIdCMB.Items.Add(row["UserID"].ToString());
                }

                // Load data into the DataGridView
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                // If tracking and source are needed
                // MessageBox.Show("Exception Message: " + ex.Message + "\n\nException Source: " + ex.Source + "\n\nException Stack Trace:" + ex.StackTrace);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the Home form
            this.Hide();
            Home temp = new Home();
            temp.ShowDialog();
        }
    }
}
