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
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace itmarathon
{
    public partial class Form2 : Form
    {
        string stringcon = System.Configuration.ConfigurationManager.ConnectionStrings["itma"].ConnectionString;
        
        public Form2()
        {
            InitializeComponent();
            PozaI();
            xmlbnr();

        }
        public void PozaI()
        {
            //string agentname;// take this from database
            //string agentpremane;// take this from database

            //SqlConnection con = new SqlConnection(stringcon);

            //SqlCommand cmd = new SqlCommand("select poza from membri where email=@EMAIL", con);
            //SqlCommand cmd2 = new SqlCommand("select nume from membri where email=@EMAIL", con);
            //SqlCommand cmd3 = new SqlCommand("select prenume from membri where email=@EMAIL", con);
            //SqlCommand cmd4 = new SqlCommand("select [role] from membri where email=@EMAIL", con);

            //cmd.Parameters.AddWithValue("@EMAIL", Form1.Email);
            //cmd2.Parameters.AddWithValue("@EMAIL", Form1.Email);
            //cmd3.Parameters.AddWithValue("@EMAIL", Form1.Email);
            //cmd4.Parameters.AddWithValue("@EMAIL", Form1.Email);

            //SqlDataAdapter dt = new SqlDataAdapter(cmd);
            //DataSet ds = new DataSet();
            //DataSet ds12 = new DataSet();
            //dt.Fill(ds);
            //con.Open();
            //Object temp = cmd4.ExecuteScalar();
            //functionlabel.Text = temp.ToString();
           
            //Object temp_dash = cmd3.ExecuteScalar();
            //agentfullnamevieww.Text = temp_dash.ToString();
            //agentpremane = temp_dash.ToString();
            //Object temp_dash1 = cmd2.ExecuteScalar();
            //agentfullnamevieww.Text = temp_dash.ToString();
            //agentname = temp_dash1.ToString();
            //string agentfullname = agentname + " " + agentpremane;
            //agentfullnamevieww.Text = agentfullname;
            //con.Close();
            //byte[] ap = (byte[])ds.Tables[0].Rows[0]["poza"];
            //MemoryStream ms = new MemoryStream(ap);
            //afriCircleImage1.Image = Image.FromStream(ms);
            ////show datagridview columns
            //con.Open();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string currenttime = DateTime.Now.ToLongTimeString();
            string currentdate = DateTime.Now.ToShortDateString();
            dateandtime.Text = currenttime + " - " + currentdate;
        }

        private void clientsbutton_Click(object sender, EventArgs e)
        {
            team_panel.Visible = true;
            dashboard_panel.Visible = false;
            department_panel.Visible = false;
            partner_panel.Visible = false;
            project_panel.Visible = false;
            meeting_panel.Visible = false;

            GridMem();

        }

        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            team_panel.Visible = false;
            dashboard_panel.Visible = true;
            department_panel.Visible = false;
            partner_panel.Visible = false;
            project_panel.Visible = false;
            meeting_panel.Visible = false;
        }

        private void propertiesbutton_Click(object sender, EventArgs e)
        {
            meeting_panel.Visible = false;
            team_panel.Visible = false;
            dashboard_panel.Visible = false;
            department_panel.Visible = true;
            partner_panel.Visible = false;
            project_panel.Visible = false;

            GridDepart();

        }

        private void addteammate_button_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(stringcon);
                SqlCommand cmd = new SqlCommand();

                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "select * from departament";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    bunifuDropdown2.AddItem(dr["numedep"].ToString());
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            addteammate_panel.Visible = true;
            addteammate_panel.BringToFront();
        }

        private void validateaddmember_button_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox4.Image.Save(ms, pictureBox4.Image.RawFormat);
            byte[] a = ms.ToArray();
            ms.Close();

            SqlConnection con = new SqlConnection(stringcon);//CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO membri(nume,prenume,anstudii,facultatea,email,parola,telefon,[role],functia,departnume,descrierepersonala,poza,dataora) VALUES(@nume,@prenume,@an,@fac,@em,@par,@telefon,@role,@functia,@departnume,@des,@p,@data)";

            cmd.Parameters.AddWithValue("@nume", firstname_textbox.Text);
            cmd.Parameters.AddWithValue("@prenume", lastname_textbox.Text);
            cmd.Parameters.AddWithValue("@an", materialSingleLineTextField11.Text);
            cmd.Parameters.AddWithValue("@fac", materialSingleLineTextField10.Text);
            cmd.Parameters.AddWithValue("@em", email_textbox.Text);
            cmd.Parameters.AddWithValue("@par", repeatpassword_textbox.Text);
            cmd.Parameters.AddWithValue("@telefon", phone_textbox.Text);
            cmd.Parameters.AddWithValue("@role", role_dropbox.selectedValue);
            cmd.Parameters.AddWithValue("@functia", function_textbox.Text);
            cmd.Parameters.AddWithValue("@departnume", bunifuDropdown2.selectedValue);
            cmd.Parameters.AddWithValue("@des", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));

            cmd.Parameters.AddWithValue("@p", a);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GridMem();

            addteammate_panel.Visible = false;
            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();
        }

        private void teamlist_button_Click(object sender, EventArgs e)
        {
            addteammate_panel.Visible = false;
            interogate_teammate_panel.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
            panel3.Visible = true;
            panel3.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection(stringcon);//CONNECTION
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Clear();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO departament(numedep,emaildep,telefondep,locatie,descriere,dataora) VALUES(@nume,@emai,@telefon,@loca,@desc,@data)";

                cmd.Parameters.AddWithValue("@nume", materialSingleLineTextField14.Text);
                cmd.Parameters.AddWithValue("@emai", materialSingleLineTextField13.Text);
                cmd.Parameters.AddWithValue("@telefon", materialSingleLineTextField12.Text);
                cmd.Parameters.AddWithValue("@loca", materialSingleLineTextField3.Text);
                cmd.Parameters.AddWithValue("@desc", richTextBox2.Text);
            cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));


            con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            GridDepart();




            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();

            panel3.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }
        int counterseccondforvalidateerror;
        private void timer2_Tick(object sender, EventArgs e)
        {
            counterseccondforvalidateerror = counterseccondforvalidateerror + 100;
            if (counterseccondforvalidateerror == 4000)
            {
                insertpopupanimation.Hide(bunifuCustomLabel6);
                bunifuCustomLabel6.Visible = false;
                timer2.Stop();
                counterseccondforvalidateerror = 0;
            }
            else
                return;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG(*JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(f.FileName);
            }
        }
        public void GridDepart()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id,numedep,emaildep,telefondep,locatie from departament", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid1.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid1.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid1.Columns[0].Width = 50;

            con.Close();
        }
        public void GridMem3()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id, CONCAT(nume,' ',prenume) as NUME,[role],facultatea,anstudii from membri", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid4.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid4.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid4.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid4.Columns[0].Width = 50;

            con.Close();
        }
        public void GridMem4()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id, CONCAT(nume,' ',prenume) as NUME,[role],facultatea,anstudii from membri", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid9.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid9.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid9.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid9.Columns[0].Width = 50;

            con.Close();
        }
        public void GridMem2()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id, CONCAT(nume,' ',prenume) as NUME,[role],facultatea,anstudii from membri", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid2.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid2.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid2.Columns[0].Width = 50;

            con.Close();
        }

        public void GridMem()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id, CONCAT(nume,' ',prenume) as NUME,[role],facultatea,anstudii from membri", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            teamgrid.DataSource = dt3;

            //store autosized widths
            int colw = teamgrid.Columns[0].Width;
            //remove autosizing
            teamgrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            teamgrid.Columns[0].Width = 50;

            con.Close();
        }
        public void GridProi()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id, numeproiect,locatiep,finalizare from proiect", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid3.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid3.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid3.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid3.Columns[0].Width = 50;

            con.Close();
        }
        public void GridProie()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id, numeproiect,locatiep,finalizare from proiect", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid8.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid8.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid8.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid8.Columns[0].Width = 50;

            con.Close();
        }

        public void GridPar()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id,numefirma,cui,jro,nume,prenume,telefon from partener", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid7.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid7.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid7.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid7.Columns[0].Width = 50;

            con.Close();
        }
        private void teamgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(teamgrid.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from membri where id=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {
                string fullname;
                string firstname;
                string lastname;
              
                firstname = dr["nume"].ToString();
                lastname = dr["prenume"].ToString();

                label17.Text = firstname;
                label18.Text = lastname;
                label19.Text = dr["telefon"].ToString();
                label20.Text = dr["email"].ToString();
                label21.Text = dr["functia"].ToString();
                label22.Text = dr["role"].ToString();
                label23.Text = dr["departnume"].ToString();
                label24.Text = dr["facultatea"].ToString();
                label16.Text = dr["anstudii"].ToString();


                fullname = lastname + " " + firstname;
                agentname_label.Text = fullname;
                personaldescriprion_label.Text = dr["descrierepersonala"].ToString();
                dateandtime_label.Text = Convert.ToDateTime(dr["dataora"]).ToString("dd/MM/yyyy - HH:mm");
                byte[] ap = (byte[])ds.Tables[0].Rows[0]["poza"];
                MemoryStream ms = new MemoryStream(ap);
                pictureBox2.Image = Image.FromStream(ms);
            }
            con.Close();
            interogate_teammate_panel.Visible = true;
            interogate_teammate_panel.BringToFront();
        }
        public int idd;
        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            idd = Convert.ToInt32(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from departament where id=" + idd + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {

                label63.Text = dr["numedep"].ToString(); 
               
                label41.Text = dr["emaildep"].ToString();
                label40.Text = dr["emaildep"].ToString();
                label39.Text = dr["telefondep"].ToString();
                label38.Text = dr["locatie"].ToString();                     
                label33.Text = dr["descriere"].ToString();
                label60.Text = Convert.ToDateTime(dr["dataora"]).ToString("dd/MM/yyyy - HH:mm");
                if (label34.Text == "") { label34.Text = "n/a"; } else
                {
                    label34.Text = dr["numeatasat"].ToString();
                }
            }
            con.Close();
            panel2.Visible = true;
            panel2.BringToFront();
            GridMem2();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(stringcon); //CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con2;
            cmd.CommandText = "update departament set numeatasat=@lang where id=@id";
            cmd.Parameters.AddWithValue("@lang", label34.Text);
            cmd.Parameters.AddWithValue("@id", idd);

            con2.Open();
            cmd.ExecuteNonQuery();
            con2.Close();


            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();

        }
        public int idr;

        private void bunifuCustomDataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idr = Convert.ToInt32(bunifuCustomDataGrid2.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from membri where id=" + idr + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {

                string fullname;
                string firstname;
                string lastname;

                firstname = dr["nume"].ToString();
                lastname = dr["prenume"].ToString();

                label17.Text = firstname;
                label18.Text = lastname;
                


                fullname = lastname + " " + firstname;
                label34.Text = fullname;


            }
            con.Close();
            panel2.Visible = true;
            panel2.BringToFront();
            GridMem2();
        }
        public string databnrvalutecurrent, eurcoinvalue, usdcoinvalue, chfcoinvalue, gbpcoinvalue;

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel7.BringToFront();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(stringcon);//CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO partener(numefirma,cui,jro,nume,prenume,adreasa,email,telefon,descrierea,dataora) VALUES(@numef,@cui,@jro,@nume,@prenume,@adresa,@email,@telefon,@des,@data)";

            cmd.Parameters.AddWithValue("@numef", materialSingleLineTextField20.Text);
            cmd.Parameters.AddWithValue("@cui", materialSingleLineTextField19.Text);
            cmd.Parameters.AddWithValue("@jro", materialSingleLineTextField18.Text);
            cmd.Parameters.AddWithValue("@nume", materialSingleLineTextField28.Text);
            cmd.Parameters.AddWithValue("@prenume", materialSingleLineTextField27.Text);
            cmd.Parameters.AddWithValue("@adresa", materialSingleLineTextField26.Text);
            cmd.Parameters.AddWithValue("@email", materialSingleLineTextField25.Text);
            cmd.Parameters.AddWithValue("@telefon", materialSingleLineTextField23.Text);
            cmd.Parameters.AddWithValue("@des", richTextBox6.Text);

            cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GridDepart();


            panel7.Visible = false;
            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();
        
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = false;
        }

        private void bunifuFlatButton20_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel9.BringToFront();
        }

        private void bunifuFlatButton21_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(stringcon);//CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO sedinta(nume,locatie,scop,data,descriere,datainreg) VALUES(@numep,@loc,@f,@data,@desc,@d)";
            string data = Convert.ToString(bunifuDatepicker1.Value.Date);
            cmd.Parameters.AddWithValue("@numep", materialSingleLineTextField30.Text);
            cmd.Parameters.AddWithValue("@loc", materialSingleLineTextField29.Text);
            cmd.Parameters.AddWithValue("@f", materialSingleLineTextField24.Text);
            cmd.Parameters.AddWithValue("@desc", richTextBox7.Text);
            cmd.Parameters.AddWithValue("@data", data) ;
            cmd.Parameters.AddWithValue("@d", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            panel9.Visible = false;
            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();

        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel8.Visible = false;
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(stringcon); //CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con2;
            cmd.CommandText = "update sedinta set numeasociati=@lang where id=@id";
            cmd.Parameters.AddWithValue("@lang", label712.Text);
            cmd.Parameters.AddWithValue("@id", idsed);

            con2.Open();
            cmd.ExecuteNonQuery();
            con2.Close();


            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();

        }

        private void statisticsbutton_Click(object sender, EventArgs e)
        {
            meeting_panel.Visible = false;
            GridPar();
            team_panel.Visible = false;
            dashboard_panel.Visible = false;
            department_panel.Visible = false;
            partner_panel.Visible = true;
            project_panel.Visible = false;
        }
private void projectsbutton_Click(object sender, EventArgs e)
        {
            meeting_panel.Visible = false;
            team_panel.Visible = false;
            dashboard_panel.Visible = false;
            department_panel.Visible = false;
            partner_panel.Visible = false;
            project_panel.Visible = true;
            GridProi();
            GridMem3();
        }
        public int idp;
        private void bunifuCustomDataGrid7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            idp = Convert.ToInt32(bunifuCustomDataGrid7.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from partener where id=" + idp + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {
           

                label108.Text = dr["numefirma"].ToString();
                label10.Text = dr["numefirma"].ToString();



                label99.Text = dr["cui"].ToString();
                label118.Text = dr["jro"].ToString();
                label117.Text = dr["nume"].ToString();
                label116.Text = dr["prenume"].ToString();
                label115.Text = dr["adreasa"].ToString();
                label114.Text = dr["email"].ToString();
                label93.Text = dr["telefon"].ToString();

                label97.Text = dr["descrierea"].ToString();
                label106.Text = Convert.ToDateTime(dr["dataora"]).ToString("dd/MM/yyyy - HH:mm");
            
            }
            con.Close();
            panel6.Visible = true;
            panel6.BringToFront();
            GridMem3();
            GridProie();

        }
        public int idpp;
        private void bunifuCustomDataGrid3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            idpp = Convert.ToInt32(bunifuCustomDataGrid3.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from proiect where id=" + idpp + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {


                label89.Text = dr["numeproiect"].ToString();
                label75.Text = dr["locatiep"].ToString();

                label78.Text = dr["finalizare"].ToString();

                label74.Text = dr["descriere"].ToString();
                label87.Text = Convert.ToDateTime(dr["dataora"]).ToString("dd/MM/yyyy - HH:mm");

            }
            con.Close();
            panel5.Visible = true;
            panel5.BringToFront();
            bunifuFlatButton11.Visible = true;


        }

        private void bunifuCustomDataGrid4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(bunifuCustomDataGrid4.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from membri where id=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {

                label61.Text = dr["nume"].ToString()+" "+ dr["prenume"].ToString();

            }
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(stringcon); //CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con2;
            cmd.CommandText = "update proiect set numeatasat=@lang where id=@id";
            cmd.Parameters.AddWithValue("@lang", label61.Text);
            cmd.Parameters.AddWithValue("@id", idpp);

            con2.Open();
            cmd.ExecuteNonQuery();
            con2.Close();


            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();

        }
        public int idproc;
        private void bunifuCustomDataGrid8_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            idproc = Convert.ToInt32(bunifuCustomDataGrid8.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from proiect where id=" + idproc + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {

                label64.Text = dr["numeproiect"].ToString();

            }
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(stringcon); //CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con2;
            cmd.CommandText = "update partener set numeproiect=@lang where id=@id";
            cmd.Parameters.AddWithValue("@lang", label64.Text);
            cmd.Parameters.AddWithValue("@id", idp);

            con2.Open();
            cmd.ExecuteNonQuery();
            con2.Close();


            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();

        }

        private void financialbutton_Click(object sender, EventArgs e)
        {
            meeting_panel.Visible = true;
            team_panel.Visible = false;
            dashboard_panel.Visible = false;
            department_panel.Visible = false;
            partner_panel.Visible = false;
            project_panel.Visible = false;
            GridMem4();
            GridSedin();
        }
        public void GridSedin()
        {
            SqlConnection con = new SqlConnection(stringcon);
            SqlCommand cmdread3 = new SqlCommand("Select id,nume,locatie,scop,data from sedinta", con);
            con.Open();
            cmdread3.ExecuteNonQuery();
            con.Close();
            DataTable dt3 = new DataTable();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmdread3);
            sda2.Fill(dt3);
            bunifuCustomDataGrid11.DataSource = dt3;

            //store autosized widths
            int colw = bunifuCustomDataGrid11.Columns[0].Width;
            //remove autosizing
            bunifuCustomDataGrid11.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //set width to calculated by autosize
            bunifuCustomDataGrid11.Columns[0].Width = 50;

            con.Close();
        }
        public int idsed;
        private void bunifuCustomDataGrid9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            id = Convert.ToInt32(bunifuCustomDataGrid9.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from membri where id=" + id + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {

                label712.Text = dr["nume"].ToString()+" "+ dr["prenume"].ToString();
               
            }
        }

        private void bunifuCustomDataGrid11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idsed = Convert.ToInt32(bunifuCustomDataGrid11.Rows[e.RowIndex].Cells["id"].Value.ToString());
            SqlConnection con = new SqlConnection(stringcon);
            con.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select * from sedinta where id=" + idsed + "";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da1.Fill(ds);
            da.Fill(dt);




            foreach (DataRow dr in dt.Rows)
            {

                label136.Text = dr["nume"].ToString();
                label128.Text = dr["nume"].ToString();
                label127.Text = dr["locatie"].ToString();
                label124.Text = dr["scop"].ToString();
                label123.Text = dr["data"].ToString();
                label134.Text = Convert.ToDateTime(dr["datainreg"]).ToString("dd/MM/yyyy - HH:mm");
                panel8.Visible = true;
                panel8.BringToFront();
            }

        }

        private void materialSingleLineTextField21_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id,nume,locatie,scop,data,numeasociati from sedinta where numeasociati LIKE '" + materialSingleLineTextField21.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid11.DataSource = d;

            con.Close();

          
        }

        private void materialSingleLineTextField22_TextChanged(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id,nume,locatie,scop,data from sedinta where id LIKE '" + materialSingleLineTextField22.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid11.DataSource = d;

            con.Close();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            GridSedin();
            materialSingleLineTextField21.Clear();
            materialSingleLineTextField22.Clear();
        }

        private void materialSingleLineTextField9_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id, CONCAT(nume,' ',prenume) as NUME,[role],facultatea,anstudii from membri where CONCAT(nume,' ',prenume) LIKE '" + materialSingleLineTextField9.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            teamgrid.DataSource = d;

            con.Close();
        }

        private void materialSingleLineTextField8_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id, CONCAT(nume,' ',prenume) as NUME,[role],facultatea,anstudii from membri where id LIKE '" + materialSingleLineTextField8.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            teamgrid.DataSource = d;

            con.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            GridMem();
            materialSingleLineTextField9.Clear();
            materialSingleLineTextField8.Clear();
        }

        private void materialSingleLineTextField1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id,numedep,emaildep,telefondep,locatie,numeatasat from departament where numeatasat LIKE '" + materialSingleLineTextField1.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid1.DataSource = d;

            con.Close();

        }

        private void materialSingleLineTextField2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id,numedep,emaildep,telefondep,locatie,numeatasat from departament where id LIKE '" + materialSingleLineTextField2.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid1.DataSource = d;

            con.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            GridDepart();
            materialSingleLineTextField1.Clear();
            materialSingleLineTextField2.Clear();
        }

        private void materialSingleLineTextField7_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id,numefirma,cui,jro,nume,prenume,telefon from partener where numefirma LIKE '" + materialSingleLineTextField7.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid7.DataSource = d;

            con.Close();
        }

        private void materialSingleLineTextField17_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id, numefirma, cui, jro, nume, prenume, telefon from partener where id LIKE '" + materialSingleLineTextField17.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid7.DataSource = d;

            con.Close();

            
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            GridPar();
            materialSingleLineTextField17.Clear();
            materialSingleLineTextField7.Clear();
        }

        private void materialSingleLineTextField4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id, numeproiect,locatiep,finalizare from proiect where numeproiect LIKE '" + materialSingleLineTextField4.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid3.DataSource = d;

            con.Close();
        }

        private void materialSingleLineTextField5_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id, numeproiect,locatiep,finalizare from proiect where id LIKE '" + materialSingleLineTextField5.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid3.DataSource = d;

            con.Close();
        }

        private void materialSingleLineTextField5_TextChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(stringcon);

            con.Open();

            SqlDataAdapter ecch = new SqlDataAdapter("Select id, numeproiect,locatiep,finalizare from proiect where id LIKE '" + materialSingleLineTextField5.Text + "%'", con);


            DataTable d = new DataTable();
            ecch.Fill(d);
            bunifuCustomDataGrid3.DataSource = d;

            con.Close();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            GridProi();
            materialSingleLineTextField4.Clear();
            materialSingleLineTextField5.Clear();
        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void afriCircleImage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_button_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Form1 dash = new Form1(); //next to app form              
            dash.Show(); //show app form
            this.Hide(); //login form hide
            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(stringcon);//CONNECTION
            SqlCommand cmd = new SqlCommand();

            cmd.Parameters.Clear();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO proiect(numeproiect,locatiep,finalizare,descriere,dataora) VALUES(@numep,@loc,@f,@desc,@data)";

            cmd.Parameters.AddWithValue("@numep", materialSingleLineTextField16.Text);
            cmd.Parameters.AddWithValue("@loc", materialSingleLineTextField15.Text);
            cmd.Parameters.AddWithValue("@f", materialSingleLineTextField6.Text);
            cmd.Parameters.AddWithValue("@desc", richTextBox3.Text);
            cmd.Parameters.AddWithValue("@data", DateTime.Now.ToString("yyyy-MM-dd HH: mm:ss"));


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GridProi();

            panel4.Visible = false;
            insertpopupanimation.Show(bunifuCustomLabel6); bunifuCustomLabel6.Visible = true; bunifuCustomLabel6.BringToFront(); timer2.Start();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void xmlbnr()
        {
            string currentdata = string.Empty;
            string coin = string.Empty;
            string value = string.Empty;
            DataTable dt10 = new DataTable();
            dt10.Columns.Add("Date", typeof(string));
            dt10.Columns.Add("Coin", typeof(string));
            dt10.Columns.Add("Value", typeof(string));
            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.bnr.ro/nbrfxrates.xml");
            XmlNodeList xmlDate = doc.GetElementsByTagName("Cube");
            XmlNodeList listdata = doc.GetElementsByTagName("Rate");
            foreach (XmlNode item in xmlDate)
            {
                currentdata = item.Attributes["date"].Value.ToString();
            }
            foreach (XmlNode item in listdata)
            {
                coin = item.Attributes["currency"].Value.ToString();
                value = item.InnerText;
                dt10.Rows.Add(currentdata, coin, value);
            }
            DataSet ds = new DataSet();
            foreach (DataRow dr in dt10.Rows)
            {
                string databnrvalute = dr["Date"].ToString();
                string eur = dr["Coin"].ToString();
                string gbp = dr["Coin"].ToString();
                string usd = dr["Coin"].ToString();
                string CHF = dr["Coin"].ToString();
                if (eur == "EUR") { databnrvalutecurrent = dr["Date"].ToString(); }

                if (eur == "EUR") { eurcoinvalue = dr["Value"].ToString(); }
                if (usd == "USD") { usdcoinvalue = dr["Value"].ToString(); }
                if (gbp == "GBP") { gbpcoinvalue = dr["Value"].ToString(); }
                if (CHF == "CHF") { chfcoinvalue = dr["Value"].ToString(); }
            }
            label54.Text = "Cursul valutar BNR comunicat în " + databnrvalutecurrent + " este: EUR=" + eurcoinvalue + " LEI" + " USD=" + usdcoinvalue + " LEI" + " CHF=" + chfcoinvalue + " LEI" + " GBP=" + gbpcoinvalue + " LEI";

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label54.Left < -700) { label54.Left = label54.Left + 1800; } else { label54.Left -= 1; }
        }
    }

    



}
