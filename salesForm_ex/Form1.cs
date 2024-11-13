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
            if (txtCustomer.Text.Length == 0 || txtItem.Text.Length == 0 || txtQty.Text.Length == 0 || txtPrice.Text.Length == 0)
            {
                MessageBox.Show("고객명, 상품명, 수량 및 가격을 확인하세요");
                return;
            }
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
    }
}
