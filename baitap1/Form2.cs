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
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-MA993H5S\\SQLEXPRESS01;Initial Catalog=QLNV;Integrated Security=True");

        private void cbPhongbann_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Using parameterized queries for security and stability
            string id = Convert.ToString(cbPhongbann.SelectedValue);
            string sql = "SELECT * FROM NhanVien WHERE MaPhongBan = @MaPhongBan";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MaPhongBan", id);
            SqlDataAdapter a = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            a.Fill(tb);
            danhsachNVV.DataSource = tb;

            // Data binding to textboxes
            txtMaPH.DataBindings.Clear();
            txtMaPH.DataBindings.Add("Text", cbPhongbann.DataSource, "MaPhongBan");
            txtTenPH.DataBindings.Clear();
            txtTenPH.DataBindings.Add("Text", cbPhongbann.DataSource, "TenPhongBan");
            txtMaTRPH.DataBindings.Clear();
            txtMaTRPH.DataBindings.Add("Text", cbPhongbann.DataSource, "DiaChiPhong");
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = "SELECT * FROM PhongBan";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            DataTable tb = new DataTable();
            a.Fill(tb);
            cbPhongbann.DisplayMember = "TenPhongBan";
            cbPhongbann.ValueMember = "MaPhongBan";
            cbPhongbann.DataSource = tb;
        }

        Boolean addPB = false;
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear data and set add mode
            txtMaPH.Clear();
            txtTenPH.Clear();
            txtMaTRPH.Clear();
            txtMaPH.Focus();
            addPB = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd;
            if (addPB)
            {
                cmd = new SqlCommand("INSERT INTO PhongBan (MaPhongBan, TenPhongBan, DiaChiPhong) VALUES (@MaPhongBan, @TenPhongBan, @DiaChiPhong)", con);
                cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPH.Text);
                cmd.Parameters.AddWithValue("@TenPhongBan", txtTenPH.Text);
                cmd.Parameters.AddWithValue("@DiaChiPhong", txtMaTRPH.Text);
            }
            else
            {
                cmd = new SqlCommand("UPDATE PhongBan SET TenPhongBan = @TenPhongBan, DiaChiPhong = @DiaChiPhong WHERE MaPhongBan = @MaPhongBan", con);
                cmd.Parameters.AddWithValue("@TenPhongBan", txtTenPH.Text);
                cmd.Parameters.AddWithValue("@DiaChiPhong", txtMaTRPH.Text);
                cmd.Parameters.AddWithValue("@MaPhongBan", Convert.ToString(cbPhongbann.SelectedValue));
            }
            cmd.ExecuteNonQuery();
            con.Close();
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM PhongBan WHERE MaPhongBan = @MaPhongBan", con);
            cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPH.Text);
            cmd.ExecuteNonQuery();
            con.Close();
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
