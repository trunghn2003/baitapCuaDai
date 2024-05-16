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

namespace baitap1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MANHLAM\\SQLEXPRESS;Initial Catalog=QLDACT;Integrated Security=True");

        private void cbPhongbann_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Lấy giá trị đã chọn từ combobox cbPhongbann và chuyển đổi sang chuỗi
            string id = Convert.ToString(cbPhongbann.SelectedValue);
            //Tạo câu truy vấn SQL để lấy dữ liệu từ bảng NHANVIEN dựa trên mã phòng ban
            string sql = "select * from NHANVIEN where MaPH = N'" + id + "'";
            //Sử dụng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataTable
            var a = new SqlDataAdapter(sql, con);
            var tb = new DataTable();
            a.Fill(tb);
            //Gán DataTable làm nguồn dữ liệu cho datagridview danhsachNVV
            danhsachNVV.DataSource = tb;
            //Gán dữ liệu từ DataSource của combobox cbPhongbann vào các control textbox txtMaPH, txtTenPH, txtMaTRPH
            txtMaPH.DataBindings.Clear();
            txtMaPH.DataBindings.Add("Text", cbPhongbann.DataSource, "MaPH");
            txtTenPH.DataBindings.Clear();
            txtTenPH.DataBindings.Add("Text", cbPhongbann.DataSource, "tenPH");
            txtMaTRPH.DataBindings.Clear();
            txtMaTRPH.DataBindings.Add("Text", cbPhongbann.DataSource, "TRPH");

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            //Tạo câu truy vấn SQL để lấy dữ liệu từ bảng PHONGBAN
            string sql = "select * from PHONGBAN ";
            //Sử dụng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu và đổ vào DataTable
            var a = new SqlDataAdapter(sql, con);
            var tb = new DataTable();
            a.Fill(tb);
            //Cấu hình combobox cbPhongbann để hiển thị dữ liệu từ DataTable tb
            cbPhongbann.DisplayMember = "TenPH";
            cbPhongbann.ValueMember = "MaPH";
            cbPhongbann.DataSource = tb;
        }

        Boolean addPB = false;
        private void button1_Click(object sender, EventArgs e)
        {
            //Xóa dữ liệu trong các TextBox
            txtMaPH.Clear();
            txtTenPH.Clear();
            txtMaTRPH.Clear();
            //Đặt trỏ chuột vào TextBox txtMaPH
            txtMaPH.Focus();
            //Đặt biến addPB thành true
            addPB = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            //Kiểm tra biến addPB có được thiết lập thành true không
            if (addPB == true)
            {
                //Thực hiện thêm mới dữ liệu vào bảng PHONGBAN nếu addPB là true
                con.Open();
                var cmd = new SqlCommand("INSERT INTO PHONGBAN (MaPH,TenPH,TRPH) VALUES(N'" + txtMaPH.Text + "',N'" + txtTenPH.Text + "',N'" + txtMaTRPH.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
            else
            {
                //Thực hiện cập nhật dữ liệu trong bảng PHONGBAN nếu addPB là false
                con.Open();
                var cmd = new SqlCommand("UPDATE PHONGBAN   " + " SET TenPH= N'" + txtTenPH.Text + "',TRPH= N'" + txtMaTRPH.Text + " ' " + "WHERE MaPH = N'" + Convert.ToString(cbPhongbann.SelectedValue) + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                LoadData();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //Mở kết nối đến cơ sở dữ liệu
            con.Open();
            //Thực hiện lệnh SQL DELETE
            var cmd = new SqlCommand("DELETE FROM PHONGBAN WHERE MaPH = '" + txtMaPH.Text + "'", con);
            cmd.ExecuteNonQuery();
            //Đóng kết nối đến cơ sở dữ liệu
            con.Close();
            //Tải lại dữ liệu
            LoadData();
        }

        private void bntchuyen_Click(object sender, EventArgs e)
        {
             Form3 frm = new Form3();
                frm.ShowDialog();
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    }
