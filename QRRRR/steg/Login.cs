using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


using System.Net;
using System.Net.Sockets;
using System.IO;

namespace steg
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            sql.sqldata();
        }

        Regex reg = new Regex(@"[0-9A-Za-z]");
        dbase sql = new dbase();
        public static int initial = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            multiplier += 2;
            strpasser.passer = textBox1.Text;

            sql.conop();
            try
            {
                sql.sql = "select count (*) from register where userr='" + textBox1.Text + "'and pass='" + textBox2.Text + "' ";
                sql.cmd();
                sql.sqladaptor();
                sql.dsetUserREg();
                if (sql.dst.Tables[0].Rows[0][0].ToString() == "1")// default log
                {
                    strpasser.passer = textBox1.Text;
                    Dashboard m = new Dashboard();
                    m.Show();
                    this.Hide();

                }
                else if (textBox1.Text == "admin" && textBox2.Text == "123qweasdzxc") // admin for account management
                {
                    Register a = new Register();
                    a.Show();
                    strpasser.passer = textBox1.Text;

                    this.Hide();
                }
                else if (textBox1.Text == "admin1" && textBox2.Text == "123qweasdzxc") // admin for other functions
                {
                    strpasser.passer = textBox1.Text;

                    Dashboard d = new Dashboard();
                    d.Show();
                    this.Hide();
                }
                else if (int.Parse(atmpCounterLBL.Text) >= 1)
                {
                    timeremainLBL.Show();
                    initial++;
                    atmpCounterLBL.Text = initial.ToString();
                    MessageBox.Show("Incorrect Username or Password");
                    multiplier++; timer1 = new Timer();
                    timer1.Tick += new EventHandler(timer1_Tick);
                    timer1.Interval = 1000; // 1 second
                    timer1.Start();


                    button1.Enabled = false;
                    if (int.Parse(atmpCounterLBL.Text) >= 4)
                    {
                        try
                        {
                            sql.sql = "insert into ipblock  (id,pub_ip,mach_name,mach_ip) Values ('" + IdipBLockLBL.Text + "','" + PublicipLBL.Text + "','" + MachineLBL.Text + "','" + LocalipLBL.Text + "')";

                            sql.cmd();
                            sql.insert();


                            MessageBox.Show("Account has been blocked please contact the administrator");
                            button1.Hide();
                            Environment.Exit(0);
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.ToString());
                            MessageBox.Show("Error ");
                        }
                    }

                }
                else if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty( textBox2.Text ))
                {
                    MessageBox.Show("Please input Username or Password");
                    
                }
                else
                {
                        initial++;
                        atmpCounterLBL.Text = initial.ToString();
                        MessageBox.Show("Incorrect Username or Password");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldnt connect to server please check your internet connection");
            }
            sql.conclo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register a = new Register();
            a.Show();
            this.Hide();
        }
        int logcount = 10;
        public int dbaserefcount;

        private TcpClient client;
        public StreamReader rdr;
        public StreamWriter rt;



        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
               
                MachineLBL.Hide();
                LocalipLBL.Hide();
                IdipBLockLBL.Hide();
                PublicipLBL.Hide();
                
                IPAddress[] local = Dns.GetHostAddresses(Dns.GetHostName()); //getting local ip machine 
                foreach (IPAddress adrs in local)
                {
                    if (adrs.AddressFamily == AddressFamily.InterNetwork)
                    {

                        LocalipLBL.Text = adrs.ToString();
                    }
                }
                MachineLBL.Text = Dns.GetHostName(); // getting machine name 
                PublicipLBL.Text = publicipstring(); // getting public ip 

                timeremainLBL.Hide();
                SecsLBL.Hide();
                atmpCounterLBL.Text = initial.ToString();
                atmpCounterLBL.Hide();
                textBox2.UseSystemPasswordChar = true;
                timeremainLBL.Text = logcount.ToString();

                //id reference auto increment
                sql.conop();
                sql.sql = "Select * from dbo.ipblock";
                sql.cmd();
                sql.sqladaptor();
                sql.dsetpos();
                for (int x = 0; x < int.Parse(sql.dst.Tables[0].Rows.Count.ToString() + 1); x++) // auto increment id 
                {

                    IdipBLockLBL.Text = sql.dst.Tables[0].Rows.Count.ToString();
                }
                sql.conclo();

                //machine verification for blocking
                sql.conop();
                sql.sql = "select count (*) from ipblock where pub_ip='" + PublicipLBL.Text + "'and mach_name='" + MachineLBL.Text + "' ";
                sql.cmd();
                sql.sqladaptor();
                sql.dsetIpBLock();
                if (sql.dst.Tables[0].Rows[0][0].ToString() == "1") {
                   
                    MessageBox.Show("Your Machine Has been blocked Please contact the administrator");
                    Environment.Exit(0);
                }
                sql.conclo();






            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Please Connect to internet");
                Environment.Exit(0);
            }
          
        }
        public static string publicipstring (){
            using (var client = new WebClient())
            {
                return client.DownloadString("http://ifconfig.me").Replace("\n", "");
            }
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e) 
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //limit text
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^A-Z^+^a-z^+^.^+^@^+^$^\b]"))
            {
                e.Handled = true;
            }

           
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) // limit text
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^A-Z^+^a-z^+^.^+^@^+^$^\b]"))
            {
                e.Handled = true;
            }
        }

        public static int multiplier = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int totalcount = multiplier * logcount;
            int y = int.Parse(timeremainLBL.Text);
           
            SecsLBL.Text = "Penalty " + totalcount.ToString() + " Seconds";
            y--;
            if (y == 0)

                timer1.Stop();
            timeremainLBL.Text = y.ToString();
           

            if (y == 0)
            {
                button1.Enabled = true;
                timeremainLBL.Text = totalcount.ToString();
                timeremainLBL.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass bago = new ForgotPass();
            bago.Show();
            this.Hide();
        }

        private void atmpCounterLBL_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
