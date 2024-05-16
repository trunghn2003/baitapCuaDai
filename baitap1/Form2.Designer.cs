namespace baitap1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbPhongbann = new System.Windows.Forms.ComboBox();
            this.bT2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bT2DataSet = new baitap1.BT2DataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.danhsachNVV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.txtTenPH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.bT2DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaTRPH = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.bntchuyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bT2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachNVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT2DataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPhongbann
            // 
            this.cbPhongbann.FormattingEnabled = true;
            this.cbPhongbann.Location = new System.Drawing.Point(392, 35);
            this.cbPhongbann.Name = "cbPhongbann";
            this.cbPhongbann.Size = new System.Drawing.Size(206, 21);
            this.cbPhongbann.TabIndex = 0;
            this.cbPhongbann.SelectedIndexChanged += new System.EventHandler(this.cbPhongbann_SelectedIndexChanged);
            // 
            // bT2DataSetBindingSource
            // 
            this.bT2DataSetBindingSource.DataSource = this.bT2DataSet;
            this.bT2DataSetBindingSource.Position = 0;
            // 
            // bT2DataSet
            // 
            this.bT2DataSet.DataSetName = "BT2DataSet";
            this.bT2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ten phong";
            // 
            // danhsachNVV
            // 
            this.danhsachNVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachNVV.Location = new System.Drawing.Point(127, 249);
            this.danhsachNVV.Name = "danhsachNVV";
            this.danhsachNVV.RowHeadersWidth = 51;
            this.danhsachNVV.RowTemplate.Height = 24;
            this.danhsachNVV.Size = new System.Drawing.Size(847, 344);
            this.danhsachNVV.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "danh sach nhan vien";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(152, 99);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(138, 20);
            this.txtMaPH.TabIndex = 4;
            // 
            // txtTenPH
            // 
            this.txtTenPH.Location = new System.Drawing.Point(392, 105);
            this.txtTenPH.Name = "txtTenPH";
            this.txtTenPH.Size = new System.Drawing.Size(140, 20);
            this.txtTenPH.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ma Phong";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ten Phong";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(621, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ma truong phong";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(175, 156);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(115, 42);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(392, 156);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(115, 42);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Luu ";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(599, 156);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 42);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1159, 352);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 13);
            this.label19.TabIndex = 32;
            // 
            // bT2DataSetBindingSource1
            // 
            this.bT2DataSetBindingSource1.DataSource = this.bT2DataSet;
            this.bT2DataSetBindingSource1.Position = 0;
            // 
            // txtMaTRPH
            // 
            this.txtMaTRPH.Location = new System.Drawing.Point(744, 105);
            this.txtMaTRPH.Name = "txtMaTRPH";
            this.txtMaTRPH.Size = new System.Drawing.Size(135, 20);
            this.txtMaTRPH.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1011, 249);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 39;
            // 
            // bntchuyen
            // 
            this.bntchuyen.Location = new System.Drawing.Point(791, 156);
            this.bntchuyen.Name = "bntchuyen";
            this.bntchuyen.Size = new System.Drawing.Size(120, 42);
            this.bntchuyen.TabIndex = 54;
            this.bntchuyen.Text = "chuyển";
            this.bntchuyen.UseVisualStyleBackColor = true;
            this.bntchuyen.Click += new System.EventHandler(this.bntchuyen_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1380, 638);
            this.Controls.Add(this.bntchuyen);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtMaTRPH);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTenPH);
            this.Controls.Add(this.txtMaPH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.danhsachNVV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPhongbann);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bT2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachNVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bT2DataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPhongban;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView danhsachnhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbpb;
        private System.Windows.Forms.ComboBox cbPhongbann;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView danhsachNVV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.TextBox txtTenPH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.BindingSource bT2DataSetBindingSource;
        private BT2DataSet bT2DataSet;
        private System.Windows.Forms.BindingSource bT2DataSetBindingSource1;
        private System.Windows.Forms.TextBox txtMaTRPH;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bntchuyen;
    }
}