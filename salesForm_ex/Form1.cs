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
                for (int i = 0; i < 6; i++)
                fields[i] = r[i].ToString();
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
            conn.Close();
            return salecode;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 매출건으 등록하기 위한 데이터가 없는 경우 안내 메세지를 보여주고 메소드 실행을 중지한다
            if (txtCustomer.Text.Length == 0 || txtItem.Text.Length == 0 || txtQty.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
                MessageBox.Show("고객명, 상품명, 수량 및 가격을 확인하세요");
                return;
            }
            // 매출건 등록을 위한 데이터를 화면 디자인 개체에서 가져오는 코드
            int salecode = NewSaleCode();
            string customer = txtCustomer.Text;
            string item = txtItem.Text;
            DateTime date = dtDate.Value;
            int qty = int.Parse(txtQty.Text);
            int price = int.Parse(txtPrice.Text);
            conn.Open();
            string query = String.Format("insert into sales (salecode, customer, item, date, qty, price) values (@salecode, @customer, @item, @date, @qty, @price)");
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@salecode",salecode);
            cmd.Parameters.AddWithValue("@customer",customer);
            cmd.Parameters.AddWithValue("@item",item);
            cmd.Parameters.AddWithValue("@date",date);
            cmd.Parameters.AddWithValue("@qty",qty);
            cmd.Parameters.AddWithValue("@price",price);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadList();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (saleList.SelectedItems.Count > 0)
            {
                string salecode = saleList.SelectedItems[0].SubItems[0].Text;
                conn.Open();
                string query = String.Format("delete from sales where salecode = @salecode");
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@salecode",salecode);
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadList();
            }
        }
        private void btnCustomerSales_Click(object sender, EventArgs e)
        {
            txtAnalysis.Text = "";
            conn.Open();
            string query = "select customer, sum(price) from sales group by customer";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader r = cmd.ExecuteReader();
            txtAnalysis.Text = "고객명 \t 누적판매금액 \r\n";
            while (r.Read())
            {
                string row = String.Format("{0}\t{1}\r\n", r[0].ToString(), r[1].ToString());
                txtAnalysis.Text = row;
            }
            conn.Close();
        }
    }
}
