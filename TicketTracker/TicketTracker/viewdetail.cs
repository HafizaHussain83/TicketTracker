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
    public partial class viewdetail : Form
    {
        Constring constring = new Constring();

        int DisUnit = 1;
        string newline = "\r\n";
        public viewdetail()
        {
            InitializeComponent();
        }
        public void messagesShow()
        {
            List<String> commentlst = new List<String>();
            List<String> madeByLst = new List<String>();
            List<String> dateAuthoredLst = new List<String>();


            SqlCommand cmd = new SqlCommand("select Comment, WrittenBy, Date from IssueDetail where TicketID = '" + TicketIdTxtBox.Text + "' order by IssueDetail.ID DESC", constring.getCon());
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                //int counter = 0;
                while (dr.Read())
                { 

                        commentlst.Add(dr[0].ToString());
                        madeByLst.Add(dr[1].ToString());
                        dateAuthoredLst.Add(dr[2].ToString());
                      

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                
                for(int j = 0; j < commentlst.Count; j++)
                {
                    TextBox txt = new TextBox();
                    

                    txt.Multiline = true;
                    txt.ScrollBars = ScrollBars.Vertical;
                    this.panel2.Controls.Add(txt);
                    txt.Top = DisUnit*50;
                    txt.Left = 10;
                    DisUnit++;
                    txt.Size = new Size(520, 50);
                    txt.ReadOnly = true;
                    txt.Text = commentlst[j] + newline + "(Made By:" + madeByLst[j] + " " + dateAuthoredLst[j] + ")";
                }
 
            }

        }

        public void insertComment()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO IssueDetail (TicketID, WrittenBy, Comment, Date) VALUES (@TicketID, '"+LogIn.username+ "', @Comment, '"+DateTime.Now+"')", constring.getCon());
            try
            {
                // Scalar Variables
                cmd.Parameters.AddWithValue("@TicketID", TicketIdTxtBox.Text);
                cmd.Parameters.AddWithValue("@Comment", textBox1.Text);

                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {

                    TextBox txt = new TextBox();
                    txt.Multiline = true;
                    txt.ScrollBars = ScrollBars.Vertical;
                    this.panel2.Controls.Add(txt);
                    txt.Top = DisUnit * 50;
                    txt.Left = 10;
                    DisUnit++;
                    txt.Size = new Size(520, 50);
                    txt.ReadOnly = true;
                    txt.Text = textBox1.Text + newline + " (Made By:" + LogIn.username + " " + DateTime.Now + ")";
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

        private void viewdetail_Load_1(object sender, EventArgs e)
        {
            messagesShow();
            panel2.AutoScroll = true;   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submitbtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please Add the Detail First!");
            }
            else
            {
                insertComment();
               // messagesShow();
            }
        }
    }
}
