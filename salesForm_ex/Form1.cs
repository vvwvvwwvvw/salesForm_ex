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

namespace salesForm_ex
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source = .; Initial Catalog = sales; Integrated Security = True"); // DB 연결
        public Form1()
        {
            InitializeComponent();
            txtAnalysis.FullRowSelect = true;
            txtAnalysis.GridLines = true;
            txtAnalysis.View = View.Details;
        }
        public void LoadList()
        {
            saleList.Items.Clear();
            conn.Open(); // DB 오픈
            string query = "select * from sales";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            string[] fields = new string[6];
            while (r.Read())
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    fields[i] = r[i].ToString();
                }
                fields[3] = fields[3].Substring(0, 10);
                ListViewItem row = new ListViewItem(fields);
                saleList.Items.Add(row);
            }
            conn.Close();
        }
    }
}
