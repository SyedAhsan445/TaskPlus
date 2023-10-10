﻿using CRUD_Operations;
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
using System.Xml.Linq;

namespace SE_Projext.Forms
{
    public partial class SigninSgnup : Form
    {
        public SigninSgnup()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            try
            {


                if (textpassword.Text == "" || textusername.Text == "" )
                {
                    MessageBox.Show("Fields can not be Emty !");
                }
                else
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("SELECT UserID, Username, Password, RegistrationDate, Email FROM Users WHERE Username = @Username AND Password = @Password;", con);
                    cmd.Parameters.AddWithValue("@Username", textusername.Text);
                    cmd.Parameters.AddWithValue("@Password", textpassword.Text);

                    // Use ExecuteScalar to get the UserID
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);

                        var con1 = Configuration.getInstance().getConnection();
                        SqlCommand cmd1 = new SqlCommand("INSERT INTO HistoryLogin values(  @UserID, @LoginTime)", con1);//Select MAX(LoginID) From HistoryLogin)+
                        cmd1.Parameters.AddWithValue("@UserID",userId);
                        cmd1.Parameters.AddWithValue("@LoginTime", DateTime.Now);
                      
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved");
                        MessageBox.Show("Login successful. UserID: " + userId);
                        this.Hide();
                        login_form temp = new login_form();
                        temp.ShowDialog();


                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message);
                // If Track and source needed
                //+ "\n\nException Source: " +ex.Source + "\n\nException Stack Trace:"+ ex.StackTrace
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp temp = new SignUp();
            temp.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
