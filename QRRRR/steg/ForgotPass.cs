using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;




namespace steg
{
    public partial class ForgotPass : Form
    {
        dbase sql = new dbase();
        public ForgotPass()
        {
            InitializeComponent();
            sql.sqldata();
        }
        Regex reg = new Regex(@"[0-9A-Za-z]");

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        public string RandomPassword(int size = 0)
        {

            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login bago = new Login();
            bago.Show();
        }

        protected string em = "adamson@gmail.com";
        protected string ps = "abc123123.";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                sql.conop();

                sql.sql = "select count (*) from register where userr='" + textBox1.Text + "'and email='" + textBox2.Text + "' ";
                sql.cmd();
                sql.sqladaptor();
                sql.dsetUserREg();
                if (sql.dst.Tables[0].Rows[0][0].ToString() == "1")// comparison
                {
                    // change database update password
                    string pass = RandomPassword();
                    sql.sql = "Update register Set pass='" + pass + "'where userr='" + textBox1.Text + "'and email='" + textBox2.Text + "' ";
                    sql.cmd();
                    sql.sqladaptor();
                    // emailing
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                        mail.From = new MailAddress(em);
                        mail.To.Add(textBox2.Text);// send email to this address
                        mail.Subject = "Password Reset";
                        mail.Body = "Your New password is : " + pass + " Please kindly login and change your password on account settings";

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("adamsonvacproject@gmail.com", "abc123123.");
                        SmtpServer.Credentials = new System.Net.NetworkCredential(em, ps);

                        SmtpServer.EnableSsl = true;
                        SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;


                        SmtpServer.Send(mail);
                        MessageBox.Show("Password Reset");
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Email Address or username");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Email Address Does no match");
                }

                sql.conclo();
            }
            catch
            {
                MessageBox.Show("No Internet Connection to Server");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^A-Z^+^a-z^+^.^+^@^+^_^\b]"))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^A-Z^+^a-z^+^.^+^@^+^_^\b]"))
            {
                e.Handled = true;
            }
        }
    }
}
