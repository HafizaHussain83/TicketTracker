using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TicketTracker
{
    
    public partial class LogIn : Form
    {
        public static string username;
        Constring constring = new Constring();

        public LogIn()
        {
            InitializeComponent();
        }
        
            
        

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            
            username = usernameTextBox.Text;
            SqlCommand cmd = new SqlCommand("select * from users where username='" + usernameTextBox.Text + "' and password='" + passwordTextBox.Text + "'", constring.getCon());
            try
            {
                
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (IsActive() == true)
                    {
                        if (IsEmployee() == true)
                        {
                            this.Hide();
                            Ticket tk = new Ticket();
                            tk.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            this.Hide();
                            UserLayout ul = new UserLayout();
                            ul.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Account has been Deactivated");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Passwor");
                }

            }
            catch (Exception)
            {

                throw;
            }
            this.IsEmployee();
        }
        public bool IsEmployee()
        {

            bool employee = true;
            
            SqlCommand cmd = new SqlCommand("select IsEmployee from users where username='" + usernameTextBox.Text + "'", constring.getCon());
            try
            {
               
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string IsEmployee = dr[0].ToString();
                    if (IsEmployee == "True")
                    {

                        employee = true;
                    }
                    else
                    {

                        employee = false;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return employee;
        }
    

        public bool IsActive()
        {
            bool active = true;

            SqlCommand cmd = new SqlCommand("select IsActive from users where username='" + usernameTextBox.Text + "'", constring.getCon());
            try
            {
                
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string IsActive = dr[0].ToString();
                    if (IsActive == "True")
                    {

                        active = true;
                    }
                    else
                    {

                       active = false;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            return active;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
