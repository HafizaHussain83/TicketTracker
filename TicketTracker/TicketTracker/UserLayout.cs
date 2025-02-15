using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace TicketTracker
{
    public partial class UserLayout : Form
    {
        LogIn lg = new LogIn();
        Constring Constring = new Constring();
        public UserLayout()
        {
            InitializeComponent();
        }

        private void UserLayout_Load(object sender, EventArgs e)
        {
            labnamelbl.Text = LabName();
            labnamelbl.Font = new Font(labnamelbl.Font.FontFamily, 22);
            Ticketslbl.Font = new Font(Ticketslbl.Font.FontFamily, 18);
            commentlbl.Font = new Font(commentlbl.Font.FontFamily, 18);
            //splitContainer2.Panel2.
            unameLabel.Text = LogIn.username;
            unameLabel.BackColor = Color.LightBlue;
            ShowGridview();

        }
        
        public void LogOut()
        {
            this.Hide();
            this.Close();
            lg.ShowDialog();

        }

        public void ShowGridview()
        {
            string lname = LabName().ToString();
            SqlCommand cmd = new SqlCommand("SELECT Ticket.ID,Ticket.LabName, Ticket.OpenDate,Ticket.Status, Ticket.Category, Ticket.Priority, Ticket.DueDate, Ticket.Title, Ticket.Description, Ticket.Comments FROM[dbo].[Ticket] Left Join Users on Ticket.LabName = Users.LabName where Ticket.LabName ='" + lname + "' order by Ticket.ID DESC" , Constring.getCon());
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tickets");
                dataGridView1.DataSource = ds.Tables["Tickets"];


            }
            catch (Exception)
            {

                throw;
            }
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
        public void IssueDetail()
        {

            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            SqlCommand cmd = new SqlCommand("SELECT TicketID, Comment, WrittenBy, Date FROM IssueDetail where TicketID = '" + id + "' order by IssueDetail.Date DESC ", Constring.getCon());
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "IssueDetails");
                dataGridView3.DataSource = ds.Tables["IssueDetails"];


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dataGridView1_OnRowDataBound(object sender, DataGridViewCellEventArgs e)
        {
            IssueDetail();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowGridview();
        }

        private void IssueDetailtbtn_Click_1(object sender, EventArgs e)
        {
            viewdetail vd = new viewdetail();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                vd.TicketIdTxtBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                vd.ShowDialog();


            }
            else
            {
                MessageBox.Show("Please Select a Complete Row to Add Comments");
            }
        }

        private void newTicketbtn_Click_1(object sender, EventArgs e)
        {
            NewTicket newTicket = new NewTicket();
            newTicket.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LogOut();
        }

        
    }
}
