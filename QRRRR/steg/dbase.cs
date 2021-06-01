using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace steg
{
    class dbase
    {


        public string constring = null;
        public SqlConnection conn;
        public SqlCommand com;
        public string sql = null;
        public SqlDataAdapter adptsq;
        public DataSet dst;

        
        public void sqldata()
        {
            

            constring = @"Data Source = database-1.cbt8uzxgshbd.ap-southeast-1.rds.amazonaws.com,1433; Initial Catalog = steg; User ID=admin;Password=123qweasd";

            conn = new SqlConnection(constring);

        }
        public void dsetIpBLock()
        {
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.ipblock ");
        }
        public void dsetUserREg()
        {
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.register ");
        }
        public void dsettrans() {
            dst = new DataSet();
            adptsq.Fill(dst,"dbo.trans");
        }
        public void UserRegselect()
        {
            sql = "SELECT * FROM dbo.register ";
        }

        public void dsetpos()
        {
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.postbl");

        }
        public void selectpos()
        {
            sql = "select * from dbo.postbl";
        }

        
        public void cmd()
        {
            com = new SqlCommand(sql, conn);
            com.CommandType = System.Data.CommandType.Text;
        }
      

        public void sqladaptor()
        {
            adptsq = new SqlDataAdapter();
            adptsq.SelectCommand = com;
            com.ExecuteNonQuery();
        }
        public void posdbaseprev() {
            selectpos();
            cmd();
            sqladaptor();
            dsetpos();
        }

        public void prevIPBLOCK() {

            sql = "SELECT * FROM dbo.ipblock ";
            cmd();
            sqladaptor();
            dsetIpBLock();
            
        }
        public void dbasepreview()
        {
           
            UserRegselect();
            cmd();
            sqladaptor();
            dsetUserREg();
            //dataset();
        }

        public void Backupcmd() {
            string a = "USE steg";
            SqlCommand com12 = new SqlCommand(a, conn);
            SqlCommand comm = new SqlCommand(sql, conn);
            com12.ExecuteNonQuery();

            comm.ExecuteNonQuery();

        }
        public void insert()
        {
            adptsq = new SqlDataAdapter();
            adptsq.InsertCommand = com;
            com.ExecuteNonQuery();
        }
        public void conop()
        {
            conn.Open();
        }

        public void conclo()
        {
            conn.Close();
        }

        //public void dsetbackip() {
        //    dst = new DataSet();
        //    adptsq.Fill(dst, "dbo.ipblock ");
        //    dst.WriteXml(@"C:\\Users\\mark\\Desktop\\steg cap\\ipblock.xml",XmlWriteMode.WriteSchema);
        //}
        public string deyt = DateTime.Now.ToShortTimeString();
        public void backIP() {

          
            conop();
            sql = "select * from ipblock";
            cmd();
            sqladaptor();
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.ipblock ");
            dst.WriteXml(@"C:\\Users\\mark\\Desktop\\steg cap\\ipblock.xml", XmlWriteMode.WriteSchema);
            conclo();

        }
        public void backAccount()
        {


            conop();
            sql = "select * from register";
            cmd();
            sqladaptor();
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.register ");
            dst.WriteXml(@"C:\\Users\\mark\\Desktop\\steg cap\\Accounts.xml", XmlWriteMode.WriteSchema);
            conclo();

        }
        public void backTransa()
        {


            conop();
            sql = "select * from trans";
            cmd();
            sqladaptor();
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.trans ");
            dst.WriteXml(@"C:\\Users\\mark\\Desktop\\steg cap\\Transanct.xml", XmlWriteMode.WriteSchema);
            conclo();

        }
        public void backpos()
        {


            conop();
            sql = "select * from postbl";
            cmd();
            sqladaptor();
            dst = new DataSet();
            adptsq.Fill(dst, "dbo.postbl     ");
            dst.WriteXml(@"C:\\Users\\mark\\Desktop\\steg cap\\pos.xml", XmlWriteMode.WriteSchema);
            conclo();

        }
    }
}
