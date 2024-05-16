using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace baitap1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=MANHLAM\\SQLEXPRESS;Initial Catalog=QLDACT;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            string sql = "select *from NHANVIEN";
            var a = new SqlDataAdapter(sql, con);
            var tb = new DataTable();
            a.Fill(tb);
            hienthi.DataSource = tb;
        }
        Boolean addPB = false;
        private void them_Click(object sender, EventArgs e)// thêm nhân viên vào danh sách
        {
            string connectionString = "Data Source=MANHLAM\\SQLEXPRESS;Initial Catalog=QLDACT;Integrated Security=True";
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                    try
                    {
                        // Mở kết nối đến csdl
                        con.Open();
                        string sql = "INSERT INTO NHANVIEN (MaNV, anhNV, HoTen, Phai, NTNS, MaPH, Luong, Ma_NQL) " +
                                     "VALUES (@MaNV, @anhNV, @HoTen, @Phai, @NTNS, @MaPH, @Luong, @Ma_NQL)";
                        SqlCommand cmd = new SqlCommand(sql, con);

                        // Định dạng dữ liệu ảnh thành byte[]
                        byte[] imageBytes = chuyen();

                        cmd.Parameters.AddWithValue("@MaNV", txtmanv1.Text);
                        cmd.Parameters.AddWithValue("@anhNV", imageBytes);
                        cmd.Parameters.AddWithValue("@HoTen", txthoten1.Text);
                        cmd.Parameters.AddWithValue("@Phai", txtphai1.Text);
                        cmd.Parameters.AddWithValue("@NTNS", txtntns1.Text);
                        cmd.Parameters.AddWithValue("@MaPH", txtmaph1.Text);
                        cmd.Parameters.AddWithValue("@Luong", txtluong1.Text);
                        cmd.Parameters.AddWithValue("@Ma_NQL", txtmaql1.Text);

                        //thêm nv vào csdl
                        cmd.ExecuteNonQuery();
                        // Đóng kết nối đến csdl
                        con.Close();
                        // Làm mới dl hiển thị trên form
                        Form3_Load(sender, e);

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo lỗi
                        MessageBox.Show("Lỗi: " + ex.Message);
                        Form3_Load(sender, e);
                    }
            }
        } 



        private void button2_Click(object sender, EventArgs e) // lưu thông tin của các nhân viên 
        {
            string connectionString = "Data Source=MANHLAM\\SQLEXPRESS;Initial Catalog=QLDACT;Integrated Security=True";
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    {

                        try
                        {
                            if (addPB)
                            {
                                con.Open();
                                string sql = "UPDATE NHANVIEN SET anhNV = @anhNV, hoten1 = @HoTen, phai1 = @Phai, ntns1 = @NTNS, maph1 = @MaPH, luong1 = @Luong, maql1 = @MaQL WHERE manv1 = @MaNV";
                                SqlCommand cmd = new SqlCommand(sql, con);

                                // Định dạng dữ liệu ảnh thành byte[]
                                byte[] imageBytes = chuyen();

                                cmd.Parameters.AddWithValue("@MaNV", txtmanv1.Text);
                                cmd.Parameters.AddWithValue("@anhNV", imageBytes);
                                cmd.Parameters.AddWithValue("@HoTen", txthoten1.Text);
                                cmd.Parameters.AddWithValue("@Phai", txtphai1.Text);
                                cmd.Parameters.AddWithValue("@NTNS", txtntns1.Text);
                                cmd.Parameters.AddWithValue("@MaPH", txtmaph1.Text);
                                cmd.Parameters.AddWithValue("@Luong", txtluong1.Text);
                                cmd.Parameters.AddWithValue("@MaQL", txtmaql1.Text);

                                cmd.ExecuteNonQuery();
                                con.Close();
                                Form3_Load(sender, e);
                                MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng thêm nhân viên trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message);
                        }
                    }
                }
            }
        }
        private byte[] chuyen()// chuyển anh sang dữ liệu byte để lưu vào hiển thị 
        {
            FileStream fs;
            fs = new FileStream(txtchonanh.Text, FileMode.Open, FileAccess.Read);
            byte[] imagebyte = new byte[fs.Length];
            fs.Read(imagebyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return imagebyte;
        }

        private void hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)// click để hiển thị thuộc tính của các nhân viên 
        {

            try
            {
                // Lấy dòng được chọn từ DataGridView
                DataGridViewRow selectedRow = hienthi.Rows[e.RowIndex];

                // Lấy dữ liệu từ dòng được chọn
                string MaNV = Convert.ToString(selectedRow.Cells["MaNV"].Value);
                string HoTen = Convert.ToString(selectedRow.Cells["HoTen"].Value);
                string NTNS = Convert.ToString(selectedRow.Cells["NTNS"].Value);
                string Luong = Convert.ToString(selectedRow.Cells["Luong"].Value);
                string Phai = Convert.ToString(selectedRow.Cells["Phai"].Value);

                // Hiển thị dữ liệu lên các TextBox tương ứng
                txtmanv2.Text = MaNV;
                txthoten2.Text = HoTen;
                txtntns2.Text = NTNS;
                txtluong2.Text = Luong;
                txtphai2.Text = Phai;

                // Lấy dữ liệu ảnh từ cột "anhNV"
                byte[] imageData = (byte[])selectedRow.Cells["anhNV"].Value;

                // Hiển thị ảnh lên PictureBox
                MemoryStream ms = new MemoryStream(imageData);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)// cập nhập ảnh cho các nhân viên đã có trong bảng
        {
            string connectionString = "Data Source=MANHLAM\\SQLEXPRESS;Initial Catalog=QLDACT;Integrated Security=True";

            {
                using (SqlConnection con = new SqlConnection(connectionString))


                    try
                    {
                        // Kiểm tra xem có dòng nào được chọn trên DataGridView không
                        if (hienthi.SelectedRows.Count > 0)
                        {
                            // Lấy dòng được chọn đầu tiên
                            DataGridViewRow selectedRow = hienthi.SelectedRows[0];

                            // Lấy mã nhân viên từ dòng được chọn
                            string maNV = Convert.ToString(selectedRow.Cells["MaNV"].Value);

                            // Lấy đường dẫn của ảnh từ PictureBox
                            string imagePath = picanhsv.ImageLocation;

                            // Đọc dữ liệu ảnh thành mảng byte[]
                            byte[] imageBytes = File.ReadAllBytes(imagePath);

                            // Mở kết nối đến cơ sở dữ liệu

                            con.Open();

                            // Cập nhật ảnh cho nhân viên có mã nhân viên tương ứng
                            string sql = "UPDATE NHANVIEN SET anhNV = @Anh WHERE MaNV = @MaNV";
                            SqlCommand command = new SqlCommand(sql, con);
                            command.Parameters.AddWithValue("@Anh", imageBytes);
                            command.Parameters.AddWithValue("@MaNV", maNV);
                            command.ExecuteNonQuery();

                            con.Close();
                            Form3_Load(sender, e);
                            // Hiển thị thông báo thành công
                            MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
            }
        }
        private void bntchonanh_Click(object sender, EventArgs e)// chọn ảnh để hiển thị
        {
            OpenFileDialog openFile = new OpenFileDialog(); // khai bao doi tuong mo open file
            openFile.Filter = openFile.Filter = " *JPG file(*.jpg)|*.jpg| All File(*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picanhsv.ImageLocation = openFile.FileName;
                txtchonanh.Text = openFile.FileName;
            }
        }
        private void button3_Click(object sender, EventArgs e) // xoa data
        {
            string connectionString = "Data Source=MANHLAM\\SQLEXPRESS;Initial Catalog=QLDACT;Integrated Security=True";

            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        // Kiểm tra xem người dùng đã chọn một dòng trong DataGridView chưa
                        if (hienthi.SelectedRows.Count > 0)
                        {
                            // Lấy dòng được chọn đầu tiên
                            DataGridViewRow selectedRow = hienthi.SelectedRows[0];

                            // Lấy giá trị của cột "manv1" từ dòng được chọn
                            string manv = Convert.ToString(selectedRow.Cells["MaNV"].Value);

                            // Thực hiện xóa nhân viên từ cơ sở dữ liệu sử dụng mã nhân viên đã lấy được
                            con.Open();
                            string sql = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@MaNV", manv);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            // Sau khi xóa thành công, làm mới danh sách nhân viên trên DataGridView
                            Form3_Load(sender, e);

                            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtluong2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void picanhsv_Click(object sender, EventArgs e)
        {

        }

        private void maxluong_Click(object sender, EventArgs e)
        {

        }
    }
    }

   
