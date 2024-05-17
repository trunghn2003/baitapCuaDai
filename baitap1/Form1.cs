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

namespace baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Update the connection string to reflect your SQL Server instance and credentials
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MA993H5S\\SQLEXPRESS01;Initial Catalog=QLNV;Integrated Security=True");
        private static DataTable DataSource;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Thực hiện truy vấn SQL để lấy dữ liệu từ bảng NhanVien
            string sql = "select * from NhanVien";
            //Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
            var a = new SqlDataAdapter(sql, con);
            var tb = new DataTable();
            a.Fill(tb);
            //Hiển thị dữ liệu từ DataTable lên DataGridView
            Hienthi.DataSource = tb;
            //Hiển thị Form2
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhân viên từ TextBox
                string maNV = txtTim.Text.Trim();

                // Mở kết nối đến cơ sở dữ liệu
                con.Open();

                // Câu truy vấn SQL để lấy thông tin của nhân viên
                string sql = "SELECT * FROM NhanVien";

                // Nếu mã nhân viên được nhập, chỉ hiển thị thông tin của nhân viên có mã đó
                // Nếu không, hiển thị tất cả thông tin của tất cả nhân viên
                if (!string.IsNullOrWhiteSpace(maNV))
                {
                    sql += " WHERE MaNhanVien = @MaNhanVien"; // Adjusted the parameter name to match your database
                }

                // Khởi tạo SqlCommand và thêm tham số cho câu truy vấn SQL
                var command = new SqlCommand(sql, con);
                if (!string.IsNullOrWhiteSpace(maNV))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", maNV); // Ensure parameter matches the column name
                }

                // Sử dụng SqlDataAdapter để thực thi câu truy vấn và lấy dữ liệu
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Kiểm tra xem có dữ liệu được trả về hay không
                if (dataTable.Rows.Count > 0)
                {
                    // Hiển thị dữ liệu lên DataGridView
                    Hienthi.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã " + maNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi hoàn thành công việc
                con.Close();
            }
        }
    }
}
