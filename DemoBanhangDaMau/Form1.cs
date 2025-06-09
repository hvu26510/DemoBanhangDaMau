
using DemoBanhangDaMau.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoBanhangDaMau
{
    public partial class Form1 : Form
    {
        BanGiayTheThaoContext db = new BanGiayTheThaoContext();
        public Form1()
        {
            InitializeComponent();
        }


        private void LoadHoaDon()
        {
            dgvHoaDon.DataSource = db.HoaDons
                .Include(hd => hd.MaNhanVienNavigation)
                .Include(hd => hd.MaKhachHangNavigation)
                .Where(hd => hd.TrangThaiThanhToan == false).ToList()
                .Select((x, index) => new
                {
                    STT = index + 1,
                    x.MaHoaDon,
                    TenNhanVien = x.MaNhanVienNavigation.TenNhanVien,
                    TenKhachHang = x.MaKhachHangNavigation.TenKhachHang,
                    x.NgayLap,
                    x.TongTien

                }).ToList();

        }

        private void LoadSanPham()
        {
            dgvSanPham.DataSource = db.ChiTietSanPhams.Include(ctsp => ctsp.MaSanPhamNavigation)
                                    .Include(ctsp => ctsp.MaMauNavigation)
                                    .Include(ctsp => ctsp.MaKichCoNavigation).ToList()
                                    .Where(ctsp => ctsp.MaSanPhamNavigation.TenSanPham.Contains(txtTimKiem.Text))
                                    .Select((x, index) => new
                                    {
                                        STT = index + 1,
                                        x.MaChiTiet,
                                        x.MaSanPham,
                                        TenSanPham = x.MaSanPhamNavigation.TenSanPham,
                                        MauSac = x.MaMauNavigation.TenMau,
                                        Size = x.MaKichCoNavigation.Size,
                                        x.GiaBan,
                                        x.SoLuong
                                    }).ToList();
        }

        private void LoadKhachHang()
        {
            cbbKhachHang.DataSource = db.KhachHangs.Select(x => new
            {
                x.MaKhachHang,
                TenKhachHang = x.TenKhachHang + "-" + x.Sdt
            }).ToList();

            cbbKhachHang.DisplayMember = "TenKhachHang";
            cbbKhachHang.ValueMember = "MaKhachHang";
        }

        private void LoadNhanVien()
        {
            cbbNhanVien.DataSource = db.NhanViens.Select(x => new
            {
                x.MaNhanVien,
                TenNhanVien = x.TenNhanVien
            }).ToList();

            cbbNhanVien.DisplayMember = "TenNhanVien";
            cbbNhanVien.ValueMember = "MaNhanVien";
        }

        private void TinhTongTien()
        {
            decimal Tien = 0;
            if (dgvGioHang.Rows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvGioHang.Rows)
                {
                    var cellValue = decimal.Parse(r.Cells["ThanhTien"].Value.ToString());
                    Tien = Tien + cellValue;
                }
            }
            lbTongTien.Text = Tien.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadSanPham();
            LoadKhachHang();
            LoadNhanVien();
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load giỏ hàng
            int maHoaDon = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());

            dgvGioHang.DataSource = db.ChiTietHoaDons.Include(cthd => cthd.MaChiTietNavigation)
                                    .ThenInclude(ctsp => ctsp.MaSanPhamNavigation)
                                    .Where(cthd => cthd.MaHoaDon == maHoaDon)
                                    .ToList().Select((x, index) => new
                                    {
                                        STT = index + 1,
                                        x.MaHoaDon,
                                        x.MaCthd,
                                        x.MaChiTietNavigation.MaSanPhamNavigation.TenSanPham,
                                        x.MaChiTietNavigation.MaKichCoNavigation.Size,
                                        x.MaChiTietNavigation.MaMauNavigation.TenMau,
                                        x.SoLuong,
                                        x.DonGia,
                                        ThanhTien = x.SoLuong * x.DonGia
                                    }).ToList();
            //LoadKhachHang
            cbbKhachHang.SelectedValue = db.HoaDons.Where(hd => hd.MaHoaDon == maHoaDon).Select(hd => hd.MaKhachHang).FirstOrDefault();

            //LoadNhanVien
            cbbNhanVien.SelectedValue = db.HoaDons.Where(hd => hd.MaHoaDon == maHoaDon).Select(hd => hd.MaNhanVien).FirstOrDefault();


            TinhTongTien();
        }

        private void txtSoTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal KhachDua = decimal.Parse(txtSoTienKhachDua.Text);
                lbTienTraLai.Text = (decimal.Parse(lbTongTien.Text)-KhachDua).ToString();   
            }
            catch
            {

            }

        }
    }
}
