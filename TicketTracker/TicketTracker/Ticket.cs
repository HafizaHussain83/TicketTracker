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

namespace TicketTracker
{
    public partial class Ticket : Form
    {
        Constring constring = new Constring();
        LogIn lg = new LogIn();
        public static int id = 0;
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            Ticketlbl.Font = new Font(Ticketlbl.Font.FontFamily, 18);
            Commentlbl.Font = new Font(Commentlbl.Font.FontFamily, 18);
            unameLabel.Text = LogIn.username;
            ShowGridview();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        public void LogOut()
        {
            this.Hide();
            this.Close();
            lg.ShowDialog();

        }
        public void ShowGridview()
        {
            SqlCommand cmd = new SqlCommand("select * from Ticket order by Ticket.ID DESC", constring.getCon());
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

        public void editTicket()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                EditTicketAdmin eda = new EditTicketAdmin();
                id = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                
                eda.iDTextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                eda.labNameTextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                eda.comboBox1.Text = eda.EmpName();
                //eda.comboBox1.SelectedIndex.Equals (dataGridView1.CurrentRow.Cells[2].Value.ToString());
                eda.openByTextBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                eda.openDateDateTimePicker.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                eda.comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                eda.categoryTextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                eda.comboBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                eda.dueDateDateTimePicker.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                eda.relatedIssuesTextBox.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                eda.titleTextBox.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                eda.descriptionTextBox.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                eda.commentsTextBox.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

                eda.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a Complete Row to Edit Ticket");
            }
        }

        private void dataGridView1_OnRowDataBound(object sender, DataGridViewCellEventArgs e)
        {
            IssueDetail();
        }
        public void IssueDetail()
        {
            
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                SqlCommand cmd = new SqlCommand("SELECT TicketID, Comment, WrittenBy, Date FROM IssueDetail where TicketID = '"+id+ "' order by IssueDetail.Date DESC ", constring.getCon());
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "IssueDetails");
                    dataGridView2.DataSource = ds.Tables["IssueDetails"];


                }
                catch (Exception)
                {

                    throw;
                }
            }

        private void Editbtn_Click_1(object sender, EventArgs e)
        {
            editTicket();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ShowGridview();
            IssueDetail();
        }

        private void viewdetailbtn_Click_1(object sender, EventArgs e)
        {
            viewdetail vd = new viewdetail();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                vd.TicketIdTxtBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                vd.ShowDialog();


            }
            else
            {
                MessageBox.Show("Please Select a Complete Row to Add Comment");
            }
        }

        
    }
}
