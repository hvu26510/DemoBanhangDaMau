
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
                    TenNhanVien = (x.MaKhachHangNavigation == null) ? "" : x.MaNhanVienNavigation.TenNhanVien,
                    TenKhachHang = (x.MaKhachHangNavigation == null) ? "" : x.MaKhachHangNavigation.TenKhachHang,
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

        private string UpdateHoaDonDAL(HoaDon newHD)
        {
            var oldHD = db.HoaDons.FirstOrDefault(hd => hd.MaHoaDon == newHD.MaHoaDon);
            if (oldHD != null)
            {
                oldHD.MaNhanVien = newHD.MaNhanVien;
                oldHD.MaKhachHang = newHD.MaKhachHang;
                oldHD.NgayLap = newHD.NgayLap;
                oldHD.TrangThaiThanhToan = newHD.TrangThaiThanhToan;
                db.SaveChanges();
                return "Cập nhật thông tin hóa đơn thành công";
            }
            else
            {
                return "Không tìm thấy";
            }
        }

        private void UpdateHoaDonBLL(bool ThanhToan)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                int maHD = int.Parse(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());

                HoaDon newHD = new HoaDon();
                newHD.MaHoaDon = maHD;
                newHD.MaNhanVien = int.Parse(cbbNhanVien.SelectedValue.ToString());
                newHD.MaKhachHang = int.Parse(cbbKhachHang.SelectedValue.ToString());
                newHD.NgayLap = DateOnly.FromDateTime(DateTime.Now);
                newHD.TongTien = decimal.Parse(lbTongTien.Text);
                newHD.TrangThaiThanhToan = ThanhToan;
                UpdateHoaDonDAL(newHD);
                LoadHoaDon();

                dgvHoaDon.ClearSelection();
                foreach (DataGridViewRow r in dgvHoaDon.Rows)
                {
                    if (int.Parse(r.Cells[1].Value.ToString()) == maHD)
                    {
                        r.Selected = true;
                        break;
                    }
                }
            }
        }

        private void ThemCTHD(ChiTietHoaDon cthd)
        {
            db.ChiTietHoaDons.Add(cthd);
            db.SaveChanges();
        }

        private void CapNhatSoluongCTSP(ChiTietSanPham ctsp)
        {
            var oldCTSP = db.ChiTietSanPhams.FirstOrDefault(ct => ct.MaChiTiet == ctsp.MaChiTiet);
            if (oldCTSP != null)
            {
                oldCTSP.SoLuong = ctsp.SoLuong;
                db.SaveChanges();
            }
            else
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadSanPham();
            LoadKhachHang();
            LoadNhanVien();
            LoadHoaDon();
        }

        private void btnTimKiemSP_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void LoadGioHang(int maHoaDon)
        {
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
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load giỏ hàng
            int maHoaDon = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString());
            foreach (DataGridViewRow r in dgvHoaDon.Rows)
            {
                if (int.Parse(r.Cells[1].Value.ToString()) == maHoaDon)
                {
                    r.Selected = true;
                    break;
                }
            }

            LoadGioHang(maHoaDon);


        }

        private void txtSoTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal KhachDua = decimal.Parse(txtSoTienKhachDua.Text);
                lbTienTraLai.Text = (KhachDua - decimal.Parse(lbTongTien.Text)).ToString();
            }
            catch
            {

            }

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count < 20)
            {
                HoaDon newHD = new HoaDon();
                newHD.NgayLap = DateOnly.FromDateTime(DateTime.Now);
                newHD.TrangThaiThanhToan = false;
                db.HoaDons.Add(newHD);
                db.SaveChanges();


                LoadHoaDon();
            }
            else
            {
                MessageBox.Show("So luong hoa don cho toi da la 20");
            }

        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SoLuong sl = new SoLuong();
            int SoLuongNhap = 0;
            var kq = sl.ShowDialog();
            if (kq == DialogResult.OK)
            {
                SoLuongNhap = sl.soluong;
            }
            if (SoLuongNhap > 0)
            {
                int maCTSP = int.Parse(dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString());
                decimal GiaBan = decimal.Parse(dgvSanPham.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString());
                int SoLuongTon = int.Parse(dgvSanPham.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString());

                if (SoLuongNhap <= SoLuongTon)
                {
                    int maHD = int.Parse(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString());
                    ChiTietHoaDon cthd = new ChiTietHoaDon();
                    cthd.MaHoaDon = maHD;
                    cthd.DonGia = GiaBan;
                    cthd.MaChiTiet = maCTSP;
                    cthd.SoLuong = SoLuongNhap;
                    ThemCTHD(cthd);

                    ChiTietSanPham ctsp = new ChiTietSanPham();
                    ctsp.SoLuong = SoLuongTon - SoLuongNhap;
                    ctsp.MaChiTiet = maCTSP;
                    CapNhatSoluongCTSP(ctsp);
                    LoadGioHang(maHD);

                }
                else
                {
                    MessageBox.Show("Khong du so luong");
                }


                LoadSanPham();

            }
        }

        private void cbbKhachHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateHoaDonBLL(false);
        }

        private void cbbNhanVien_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateHoaDonBLL(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("A iu sua?", "Xac nhan thanh toan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) {
                if (txtSoTienKhachDua.Text == "")
                {
                    UpdateHoaDonBLL(true);

                }
                else
                {
                    if (decimal.Parse(lbTienTraLai.Text) > 0)
                    {
                        UpdateHoaDonBLL(true);
                    }
                    else
                    {
                        MessageBox.Show("Nhan thieu tien");
                    }
                }
                LoadHoaDon();
            }

            

        }
    }
}
