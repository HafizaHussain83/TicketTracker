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

    public partial class EditTicketAdmin : Form
    {
        Ticket tk = new Ticket();
        Constring constring = new Constring();
        public EditTicketAdmin()
        {
            InitializeComponent();
        }


        private void EditTicketAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);
            // TODO: This line of code loads data into the 'ticketDataSet.Ticket' table. You can move, or remove it, as needed.
            //this.ticketTableAdapter.Fill(this.ticketDataSet.Ticket);
            openDateDateTimePicker.Enabled = false;
            label2.Text = LogIn.username;
            //comboBox1.SelectedText = EmpName();
            


        }

       
        public void UpdateTicketAdmin()
        {
            int id = Int32.Parse(iDTextBox.Text);
            SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Ticket] SET AssignedTo = '" + ComboBoxSave() + "', Status = '" + comboBox2.Text + "', Category = '" + categoryTextBox.Text + "', Priority = '" + comboBox4.Text + "', DueDate = '" + dueDateDateTimePicker.Value + "', RelatedIssues = '" + relatedIssuesTextBox.Text + "'  WHERE id = '" + id + "'", constring.getCon());
            try
            {
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("This Ticket has been Updated.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error inserting data into Database!");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            UpdateTicketAdmin();
        }
        public string EmpName()
        {
            string name = "";
            int id = Ticket.id;
            if (id == 0)
            {
                string x = "Please Select One";
                name = x;
                ComboBoxItems();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select name from Employee where id = '" + id + "'", constring.getCon());
                try
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        name = dr[0].ToString();
                        ComboBoxItems();

                    }
                    dr.Close();
                }
                catch (Exception)
                {

                    throw;
                }

            }

           
            return name;
        }

        public void ComboBoxItems()
        {
            SqlCommand cmd = new SqlCommand("select name from Employee", constring.getCon());
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    string EName = dr.GetString(0);
                    comboBox1.Items.Add(EName);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int ComboBoxSave()
        {
            int id = 0;
            string Name = comboBox1.Text;
            SqlCommand cmd = new SqlCommand("select id from Employee where Name = '"+ Name +"'", constring.getCon());
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = Int32.Parse(dr[0].ToString());
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
            return id;
        }
    }
}
