using Microsoft.EntityFrameworkCore;
using QuanLyThietBi.Models;
using System.Linq;
namespace QuanLyThietBi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvThietBi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThietBi.MultiSelect = false;
            dgvThietBi.ReadOnly = true;
            dgvThietBi.AllowUserToAddRows = false;
            dgvThietBi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadData();
            TrangThaiBanDau();
        }
        private void TrangThaiBanDau()
        {
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private DuLieu_ThietBiContext TaoDbContext()
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=DuLieu_ThietBi;Trusted_Connection=true;TrustServerCertificate=true";
            var options = new DbContextOptionsBuilder<DuLieu_ThietBiContext>()
                .UseSqlServer(connectionString)
                .Options;
            return new DuLieu_ThietBiContext(options);
        }
        private void LoadData()
        {
            using (var db = TaoDbContext())
            {
                dgvThietBi.DataSource = db.ThietBis.AsNoTracking().ToList();
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            decimal donGia;
            if (!decimal.TryParse(txtDonGia.Text, out donGia) && !string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Text = "";
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text == "" || txtTenThietBi.Text == "" || txtDonGia.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = TaoDbContext())
            {
                string ma = txtMaThietBi.Text.Trim();
                if (db.ThietBis.Any(t => t.MaThietBi == ma))
                {
                    MessageBox.Show("Mã thiết bị đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var tb = new ThietBi();
                tb.MaThietBi = ma;
                tb.TenThietBi = txtTenThietBi.Text.Trim();
                tb.DonGia = txtDonGia.Text.Trim();
                db.ThietBis.Add(tb);
                db.SaveChanges();
                MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThietBi.Text = "";
                txtTenThietBi.Text = "";    
                txtDonGia.Text = "";
                LoadData();
                TrangThaiBanDau();
            }
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgvThietBi.Rows[e.RowIndex]; ;
            txtMaThietBi.Text = row.Cells["MaThietBi"].Value?.ToString();
            txtTenThietBi.Text = row.Cells["TenThietBi"].Value?.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value?.ToString();
            txtMaThietBi.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenThietBi.Text == "" || txtMaThietBi.Text == "" || txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = TaoDbContext())
            {
                string ma = txtMaThietBi.Text.Trim();
                var tb = db.ThietBis.FirstOrDefault(t => t.MaThietBi == ma);
                if (tb == null)
                {
                    MessageBox.Show("Thiết bị không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tb.TenThietBi = txtTenThietBi.Text.Trim();
                tb.DonGia = txtDonGia.Text.Trim();
                db.SaveChanges();
                MessageBox.Show("Sửa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaThietBi.Text = "";
                txtTenThietBi.Text = "";
                txtDonGia.Text = "";
                LoadData();
                TrangThaiBanDau();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa thiết bị này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = TaoDbContext())
                {
                    string ma = txtMaThietBi.Text.Trim();
                    var tb = db.ThietBis.FirstOrDefault(t => t.MaThietBi == ma);
                    if (tb != null)
                    {
                        db.ThietBis.Remove(tb);
                        db.SaveChanges();
                        MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMaThietBi.Text = "";
                        txtTenThietBi.Text = "";
                        txtDonGia.Text = "";
                        LoadData();
                        TrangThaiBanDau();
                    }
                }
            }
        }
    }
}
