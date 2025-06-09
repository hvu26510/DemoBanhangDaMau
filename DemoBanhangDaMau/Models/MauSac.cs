using System;
using System.Collections.Generic;

namespace DemoBanhangDaMau.Models;

public partial class MauSac
{
    public int MaMau { get; set; }

    public string? TenMau { get; set; }

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
