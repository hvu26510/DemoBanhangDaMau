using System;
using System.Collections.Generic;

namespace DemoBanhangDaMau.Models;

public partial class KichCo
{
    public int MaKichCo { get; set; }

    public int? Size { get; set; }

    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
