namespace QuanLyThietBi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtDonGia = new TextBox();
            txtTenThietBi = new TextBox();
            txtMaThietBi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            dgvThietBi = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(txtTenThietBi);
            groupBox1.Controls.Add(txtMaThietBi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(567, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 188);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin thiết bị";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(143, 140);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 5;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // txtTenThietBi
            // 
            txtTenThietBi.Location = new Point(143, 84);
            txtTenThietBi.Name = "txtTenThietBi";
            txtTenThietBi.Size = new Size(125, 27);
            txtTenThietBi.TabIndex = 4;
            // 
            // txtMaThietBi
            // 
            txtMaThietBi.Location = new Point(143, 39);
            txtMaThietBi.Name = "txtMaThietBi";
            txtMaThietBi.Size = new Size(125, 27);
            txtMaThietBi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 143);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá (VND):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên thiết bị";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã thiết bị:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThoat);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Location = new Point(567, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 220);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Tomato;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Indigo;
            btnXoa.Location = new Point(158, 137);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 43);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.IndianRed;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(26, 137);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 43);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.DodgerBlue;
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(158, 58);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 43);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Aquamarine;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Green;
            btnThem.Location = new Point(26, 58);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 43);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvThietBi);
            groupBox3.Location = new Point(12, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 414);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách thiết bị";
            // 
            // dgvThietBi
            // 
            dgvThietBi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThietBi.Location = new Point(6, 26);
            dgvThietBi.Name = "dgvThietBi";
            dgvThietBi.RowHeadersWidth = 51;
            dgvThietBi.Size = new Size(537, 382);
            dgvThietBi.TabIndex = 0;
            dgvThietBi.CellClick += dgvThietBi_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvThietBi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnThem;
        private GroupBox groupBox3;
        private TextBox txtDonGia;
        private TextBox txtTenThietBi;
        private TextBox txtMaThietBi;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvThietBi;
    }
}
