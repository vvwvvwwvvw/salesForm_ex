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
            saleList.Items.Clear(); // 매출 데이터 행 삭제
            conn.Open(); // DB 오픈
            string query = "select * from sales";
            SqlCommand cmd = new SqlCommand(query, conn); // DB에서 데이터 조회실행
            SqlDataReader r = cmd.ExecuteReader(); // 조회된 값 저장
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
            conn.Close(); // DB 닫기
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadList();
        }
        public int NewSaleCode()
        {
            conn.Open();
            string query = "select max(salecode)+1 from sales";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            r.Read();
            int salecode = 1;
            if (r[0].ToString().Length > 0)
            {
                salecode = int.Parse(r[0].ToString());
            }
            r.Close();
            return salecode;
        }
    }
}
