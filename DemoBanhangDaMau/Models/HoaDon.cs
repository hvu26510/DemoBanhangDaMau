using System;
using System.Collections.Generic;

namespace DemoBanhangDaMau.Models;

public partial class HoaDon
{
    public int MaHoaDon { get; set; }

    public DateOnly? NgayLap { get; set; }

    public int? MaKhachHang { get; set; }

    public int? MaNhanVien { get; set; }

    public decimal? TongTien { get; set; }

    public bool TrangThaiThanhToan { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? MaKhachHangNavigation { get; set; }

    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
