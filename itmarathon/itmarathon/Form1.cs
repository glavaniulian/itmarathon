using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.NetworkInformation;



namespace itmarathon
{
    public partial class Form1 : Form
    {
        public bool checkconnection = NetworkInterface.GetIsNetworkAvailable();
        public Form1()
        {
            InitializeComponent();
            if (checkconnection == true)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox2.Visible = true;
            }
        }

        private void watchpassbutton_MouseEnter(object sender, EventArgs e)
        {
            
                materialSingleLineTextField3.UseSystemPasswordChar = false;
            
        }

        private void watchpassbutton_MouseLeave(object sender, EventArgs e)
        {
            materialSingleLineTextField3.UseSystemPasswordChar = true;
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int countererrorseconds = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            countererrorseconds = countererrorseconds + 100;
            if (countererrorseconds == 4000)
            {
                emailerror.Visible = false;
                passworderror.Visible = false;
                loginerror.Visible = false;
                connectionerror.Visible = false;
                timer1.Stop();
                countererrorseconds = 0;
            }
            else
                return;
        }

        string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["itma"].ConnectionString;

        public static string Email="";
        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (checkconnection == true)
            {
                SqlConnection con = new SqlConnection(stringcon);
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Connection = con;

                cmd.CommandText = "SELECT * FROM membri WHERE email=@EMAIL AND parola=@PASS";
                cmd.Parameters.AddWithValue("@EMAIL", materialSingleLineTextField1.Text);
                cmd.Parameters.AddWithValue("PASS", materialSingleLineTextField3.Text);

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                dt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    Form2 dash = new Form2(); //next to app form              
                    dash.Show(); //show app form
                    this.Hide(); //login form hide
                    Email = materialSingleLineTextField1.Text;
                }

                else
                {
                    emailerror.Visible = true;
                    passworderror.Visible = true;
                    loginerror.Visible = true;
                    timer1.Start();
                }
            }
            else
            {
                connectionerror.Visible = true;
                timer1.Start();
            }
        }
    }
}
