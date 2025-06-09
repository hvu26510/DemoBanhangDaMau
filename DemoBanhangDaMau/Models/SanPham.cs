using System;
using System.Collections.Generic;

namespace DemoBanhangDaMau.Models;

public partial class SanPham
{
    public int MaSanPham { get; set; }

    public string? TenSanPham { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
