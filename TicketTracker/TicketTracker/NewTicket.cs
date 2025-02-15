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
    public partial class NewTicket : Form
    {
        Constring Constring = new Constring();
        LogIn lg = new LogIn();
       
        public NewTicket()
        {
            InitializeComponent();
        }

        private void NewTicket_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketDataSet.Ticket' table. You can move, or remove it, as needed.
           // this.ticketTableAdapter.Fill(this.ticketDataSet.Ticket);
            unameLabel.Text = userName();
            comboBox4.SelectedIndex = 0;
            OpenedBytxtbox.Text = userName().ToString();
            LabNametxt.Text = LabName();
            statustxt.Text = "Pending";
            newticketlbl.Font = new Font(newticketlbl.Font.FontFamily, 18);
            //iDTextBox.Text = NextID().ToString();
            openedDateDateTimePicker.Enabled = false;

        }
        public string userName()
        {
            string uname = LogIn.username;
            return uname;
        }
        public string LabName()
        {
            string labName = "";
            SqlCommand cmd = new SqlCommand("select LabName from users where username='" + LogIn.username + "'", Constring.getCon());
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    labName = dr[0].ToString();

                }

            }
            catch (Exception)
            {

                throw;
            }
            return labName;
        }


        public string NextID()
        {

            string nextid;

            SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]", Constring.getCon());

            try
            {
                nextid = cmd.ExecuteScalar().ToString();
                //SqlDataReader dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    string Lastid = dr[0].ToString();
                //    int lastid = Int32.Parse(Lastid);
                //    nextid = lastid + 1;

                //}

            }
            catch (Exception)
            {

                throw;
            }
            return nextid;

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryTextBox.Text) && comboBox4.SelectedIndex == 0 && String.IsNullOrEmpty(titleTextBox.Text) && String.IsNullOrEmpty(descriptionTextBox.Text))
            {
                MessageBox.Show("Please Fill All the Required Fields First!");
            }
            else
            {
                if (String.IsNullOrEmpty(categoryTextBox.Text))
                {
                    //categoryTextBox.Focus();
                    MessageBox.Show("Please Fill the Category First!");
                }
                else
                {
                    if (comboBox4.SelectedIndex == 0)
                    {
                        MessageBox.Show("Please Select a Priority Option First!");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(titleTextBox.Text))
                        {
                            MessageBox.Show("Please Fill The Title First!");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(descriptionTextBox.Text))
                            {
                                MessageBox.Show("Please Fill The Description First!");
                            }
                            else
                            {
                                SqlCommand cmd = new SqlCommand("insert into Ticket ( LabName, AssignedTo, OpenBy, OpenDate, Status, Category, Priority, DueDate, RelatedIssues, Title, Description, Comments) " +
                                "Values( @LabName, '0', @OpenedBy, @OpenedDate, @status, @category, @Priority, @dueDate, @relatedIssues, @title, @description, @comments ) SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY];  ", Constring.getCon());
                                try
                                {
                                    // Scalar Variables
                                    //cmd.Parameters.AddWithValue("@ID", iDTextBox.Text);
                                    cmd.Parameters.AddWithValue("@LabName", LabNametxt.Text);
                                    cmd.Parameters.AddWithValue("@OpenedBy", OpenedBytxtbox.Text);
                                    cmd.Parameters.AddWithValue("@OpenedDate", openedDateDateTimePicker.Value);
                                    cmd.Parameters.AddWithValue("@status", statustxt.Text);
                                    cmd.Parameters.AddWithValue("@category", categoryTextBox.Text);
                                    cmd.Parameters.AddWithValue("@Priority", comboBox4.Text);
                                    cmd.Parameters.AddWithValue("@dueDate", dueDateDateTimePicker.Value);
                                    cmd.Parameters.AddWithValue("@relatedIssues", relatedIssuesTextBox.Text);
                                    cmd.Parameters.AddWithValue("@title", titleTextBox.Text);
                                    cmd.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                                    cmd.Parameters.AddWithValue("@comments", commentsTextBox.Text);

                                    int result = cmd.ExecuteNonQuery();

                                    if (result == 1)
                                    {
                                        MessageBox.Show("Your New Ticket has been Submited.");
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
                        }
                    }
                }
                
                
                

               
            
            }
        }
    }
}
