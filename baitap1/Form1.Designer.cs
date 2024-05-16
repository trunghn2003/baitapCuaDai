namespace baitap1
{
    partial class Form1
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
            this.btnChuyen = new System.Windows.Forms.Button();
            this.Hienthi = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(775, 93);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(127, 67);
            this.btnChuyen.TabIndex = 0;
            this.btnChuyen.Text = "ChuyenForm";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.button3_Click);
            // 
            // Hienthi
            // 
            this.Hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hienthi.Location = new System.Drawing.Point(54, 77);
            this.Hienthi.Name = "Hienthi";
            this.Hienthi.RowHeadersWidth = 51;
            this.Hienthi.RowTemplate.Height = 24;
            this.Hienthi.Size = new System.Drawing.Size(675, 256);
            this.Hienthi.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tim";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(373, 363);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(228, 22);
            this.txtTim.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(954, 588);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Hienthi);
            this.Controls.Add(this.btnChuyen);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.DataGridView Hienthi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTim;
    }
}

