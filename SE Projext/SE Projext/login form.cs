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

namespace SE_Projext
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtName.Text == "" || txtDescription.Text == "" )
                {
                    MessageBox.Show("Fields can not be Emty !");
                }
                else
                {

                    txtName.Text = getCurrentUser().ToString();

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Project values( (Select Max (ProjectID) from Project)+1, @ProjectName, @Description,  @OwnerID,@CreatedDate )", con);
                    cmd.Parameters.AddWithValue("@ProjectName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@OwnerID", getCurrentUser());
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully saved");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                // If Track and source needed
                //+ "\n\nException Source: " +ex.Source + "\n\nException Stack Trace:"+ ex.StackTrace
            }
        }
    }
}
