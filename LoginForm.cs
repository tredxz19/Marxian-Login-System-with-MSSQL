using FontAwesome.Sharp;
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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Marxian_Login_System
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection con;


        public Form1()
        {
            InitializeComponent();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userregisterTb.Text == "" || passregisterTb.Text == "")
                {
                    userregisterTb.Clear();
                    passregisterTb.Clear();
                    MessageBox.Show("Please Input Username or Password");
                }
                else
                {
                    connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=Information;Integrated Security=True";
                    con = new SqlConnection(connectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into LoginTable values (@UserId,@UserPass)", con);
                    cmd.Parameters.AddWithValue("@UserId", (userregisterTb.Text));
                    cmd.Parameters.AddWithValue("@UserPass", (passregisterTb.Text));
                    cmd.ExecuteNonQuery();
                    con.Close();
                    pictureBox1.Visible = true;
                    loginPnl.Visible = true;
                    registerPnl.Left += 180;
                    userregisterTb.Clear();
                    passregisterTb.Clear();
                    MessageBox.Show("Succcessfully Saved");
                }
            }
            catch
            {
                MessageBox.Show("This useraname is already taken \n by other user.");
                userregisterTb.Clear();
                passregisterTb.Clear();
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (passregisterTb.Text == "")
            {
                MessageBox.Show("Enter Username Or Password");
                usernameTb.Text = "Username";
                humaniconPb.ForeColor = Color.DarkGray;
                usernameTb.ForeColor = Color.DarkGray;
                passTb.PasswordChar = '\0';
                passTb.Text = "Password";               
                passTb.ForeColor = Color.DarkGray;
                lockiconPb.ForeColor = Color.DarkGray;
                passregisterTb.Clear();
            }
            else if (passTb.Text == passregisterTb.Text)
            {
                ProfileForm profileFrm = new ProfileForm();
                ProfileForm.instanceForm.usernameLbl.Text = "Username:" + usernameTb.Text;
                ProfileForm.instanceForm.passwordLbl.Text = "Password:" + passTb.Text;
                profileFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                usernameTb.Text = "Username";
                humaniconPb.ForeColor = Color.DarkGray;
                usernameTb.ForeColor = Color.DarkGray;
                passTb.PasswordChar = '\0';
                passTb.Text = "Password";
                lockiconPb.ForeColor = Color.DarkGray;
                passTb.ForeColor = Color.DarkGray;
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=Information;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            if (usernameTb.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select UserPass from LoginTable where UserId = @UserId", con);
                cmd.Parameters.AddWithValue("@UserId", (usernameTb.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    passregisterTb.Text = da.GetValue(0).ToString();
                }
            }
        }
        private void passTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
            }
        }        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
                loginPnl.Visible = true;
                registerPnl.Left += 180;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                loginPnl.Visible = false;
                registerPnl.Left -= 180;
                userregisterTb.Clear();
                passregisterTb.Clear();
            }
        }
        private void passregisterTb_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    registerBtn.PerformClick();
                }
            }
        }
        private void usernameTb_Leave(object sender, EventArgs e)
        {
            if (usernameTb.Text.Length == 0 || usernameTb.Text == "")
            {
                usernameTb.Text = "Username";
                humaniconPb.ForeColor = Color.DarkGray;
                usernameTb.ForeColor = Color.DarkGray;
            }
        }
        private void usernameTb_Enter(object sender, EventArgs e)
        {
            if (usernameTb.Text == "Username")
            {
                usernameTb.Text = "";
                humaniconPb.ForeColor = Color.White;
                usernameTb.ForeColor = Color.White;
            }
        }
        private void passTb_Leave(object sender, EventArgs e)
        {
            if (passTb.Text.Length == 0 || passTb.Text == "")
            {
                passTb.Text = "Password";
                passTb.PasswordChar = '\0';
                lockiconPb.ForeColor = Color.DarkGray;
                passTb.ForeColor = Color.DarkGray;
            }
        }

        private void passTb_Enter(object sender, EventArgs e)
        {
            if (passTb.Text == "Password")
            {
                passTb.Text = "";
                passTb.ForeColor = Color.White;
                lockiconPb.ForeColor = Color.White;
                passTb.PasswordChar = '*';
            }
        }

        private void usernameTb_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {                    
                    System.Windows.Forms.SendKeys.Send("{TAB}");
                }
            }
        }

        private void userregisterTb_KeyDown(object sender, KeyEventArgs e)
        {
         if (e.KeyCode == Keys.Enter)
          {
            System.Windows.Forms.SendKeys.Send("{TAB}");
          }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            loginPnl.Visible = true;
            registerPnl.Left += 180;
            userregisterTb.Clear();
            passregisterTb.Clear();
        }
    }
}
