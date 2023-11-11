using CRUD_Operations;
using SE_Projext.Forms;
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
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
        private void reload()
        {
            // To Reload
            var con1 = Configuration.getInstance().getConnection();
            SqlCommand cmd1 = new SqlCommand("Select * from Project ", con1);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (NameText.Text == "" || DescriptionText.Text == "" )
                {
                    MessageBox.Show("Fields can not be Emty !");
                }
                else
                {


                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Project values( (Select Max (ProjectID) from Project)+1, @ProjectName, @Description,  @OwnerID,@CreatedDate )", con);
                    cmd.Parameters.AddWithValue("@ProjectName", NameText.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionText.Text);
                    cmd.Parameters.AddWithValue("@OwnerID", getCurrentUser());
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home temp = new Home();
            temp.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                DataGridViewRow dr = (DataGridViewRow)dataGridView1.CurrentRow;

                NameText.Text = dr.Cells[4].Value.ToString();
                DescriptionText.Text = dr.Cells[5].Value.ToString();


            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Update")
            {
                if (NameText.Text == "" || DescriptionText.Text == "")
                {
                    MessageBox.Show("Fields Can not be Emty !");
                }
                else
                {

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand($"UPDATE Project SET ProjectName = @ProjectName, Description = @Description WHERE ProjectID = @Id  ", con);
                    DataGridViewRow dr = (DataGridViewRow)dataGridView1.CurrentRow;

                    cmd.Parameters.AddWithValue("@Id", dr.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@ProjectName", NameText.Text);
                    cmd.Parameters.AddWithValue("@Description", DescriptionText.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully!");
                    reload();



                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand($"Delete From Project Where ProjectID = @Id", con);
                DataGridViewRow dr = (DataGridViewRow)dataGridView1.CurrentRow;
                cmd.Parameters.AddWithValue("@Id", dr.Cells[3].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!");

                
                 reload();
            }

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDescription_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
