namespace DemoBanhangDaMau
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
            panel1 = new Panel();
            btnThemHoaDon = new Button();
            label1 = new Label();
            dgvHoaDon = new DataGridView();
            panel2 = new Panel();
            btnCapNhatGioHang = new Button();
            btnXoaChiTietDonHang = new Button();
            label2 = new Label();
            dgvGioHang = new DataGridView();
            panel3 = new Panel();
            btnTimKiemSP = new Button();
            txtTimKiem = new TextBox();
            label3 = new Label();
            dgvSanPham = new DataGridView();
            panel4 = new Panel();
            lbTienTraLai = new Label();
            label10 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtSoTienKhachDua = new TextBox();
            cbbNhanVien = new ComboBox();
            cbbKhachHang = new ComboBox();
            label9 = new Label();
            lbTongTien = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThemHoaDon);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvHoaDon);
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 195);
            panel1.TabIndex = 1;
            // 
            // btnThemHoaDon
            // 
            btnThemHoaDon.Location = new Point(697, 6);
            btnThemHoaDon.Name = "btnThemHoaDon";
            btnThemHoaDon.Size = new Size(92, 35);
            btnThemHoaDon.TabIndex = 15;
            btnThemHoaDon.Text = "Thêm";
            btnThemHoaDon.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Dock = DockStyle.Bottom;
            dgvHoaDon.Location = new Point(0, 47);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.Size = new Size(909, 148);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCapNhatGioHang);
            panel2.Controls.Add(btnXoaChiTietDonHang);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvGioHang);
            panel2.Location = new Point(12, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 195);
            panel2.TabIndex = 2;
            // 
            // btnCapNhatGioHang
            // 
            btnCapNhatGioHang.Location = new Point(697, 3);
            btnCapNhatGioHang.Name = "btnCapNhatGioHang";
            btnCapNhatGioHang.Size = new Size(92, 35);
            btnCapNhatGioHang.TabIndex = 17;
            btnCapNhatGioHang.Text = "Cập nhật";
            btnCapNhatGioHang.UseVisualStyleBackColor = true;
            // 
            // btnXoaChiTietDonHang
            // 
            btnXoaChiTietDonHang.Location = new Point(803, 3);
            btnXoaChiTietDonHang.Name = "btnXoaChiTietDonHang";
            btnXoaChiTietDonHang.Size = new Size(92, 35);
            btnXoaChiTietDonHang.TabIndex = 16;
            btnXoaChiTietDonHang.Text = "Xóa";
            btnXoaChiTietDonHang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Danh sách giỏ hàng";
            // 
            // dgvGioHang
            // 
            dgvGioHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGioHang.Dock = DockStyle.Bottom;
            dgvGioHang.Location = new Point(0, 45);
            dgvGioHang.Name = "dgvGioHang";
            dgvGioHang.Size = new Size(909, 150);
            dgvGioHang.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTimKiemSP);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvSanPham);
            panel3.Location = new Point(12, 471);
            panel3.Name = "panel3";
            panel3.Size = new Size(909, 285);
            panel3.TabIndex = 3;
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.Location = new Point(234, 27);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(92, 23);
            btnTimKiemSP.TabIndex = 18;
            btnTimKiemSP.Text = "Tìm kiếm";
            btnTimKiemSP.UseVisualStyleBackColor = true;
            btnTimKiemSP.Click += btnTimKiemSP_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(14, 27);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(194, 23);
            txtTimKiem.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 3;
            label3.Text = "Danh sách sản phẩm";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Bottom;
            dgvSanPham.Location = new Point(0, 56);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.Size = new Size(909, 229);
            dgvSanPham.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbTienTraLai);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(txtSoTienKhachDua);
            panel4.Controls.Add(cbbNhanVien);
            panel4.Controls.Add(cbbKhachHang);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lbTongTien);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(934, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(294, 734);
            panel4.TabIndex = 4;
            // 
            // lbTienTraLai
            // 
            lbTienTraLai.AutoSize = true;
            lbTienTraLai.BackColor = Color.Transparent;
            lbTienTraLai.Location = new Point(93, 400);
            lbTienTraLai.Name = "lbTienTraLai";
            lbTienTraLai.Size = new Size(56, 15);
            lbTienTraLai.TabIndex = 16;
            lbTienTraLai.Text = "lbTienTra";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 368);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 15;
            label10.Text = "Số tiền trả lại";
            // 
            // button2
            // 
            button2.Location = new Point(184, 465);
            button2.Name = "button2";
            button2.Size = new Size(75, 43);
            button2.TabIndex = 14;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 465);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 13;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSoTienKhachDua
            // 
            txtSoTienKhachDua.Location = new Point(65, 328);
            txtSoTienKhachDua.Name = "txtSoTienKhachDua";
            txtSoTienKhachDua.Size = new Size(194, 23);
            txtSoTienKhachDua.TabIndex = 12;
            txtSoTienKhachDua.TextChanged += txtSoTienKhachDua_TextChanged;
            // 
            // cbbNhanVien
            // 
            cbbNhanVien.FormattingEnabled = true;
            cbbNhanVien.Location = new Point(46, 148);
            cbbNhanVien.Name = "cbbNhanVien";
            cbbNhanVien.Size = new Size(213, 23);
            cbbNhanVien.TabIndex = 11;
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(46, 75);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(213, 23);
            cbbKhachHang.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 293);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 9;
            label9.Text = "Số tiền khách đưa:";
            // 
            // lbTongTien
            // 
            lbTongTien.AutoSize = true;
            lbTongTien.BackColor = Color.Transparent;
            lbTongTien.Location = new Point(93, 252);
            lbTongTien.Name = "lbTongTien";
            lbTongTien.Size = new Size(100, 15);
            lbTongTien.TabIndex = 8;
            lbTongTien.Text = "Hiển thị tổng tiền";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 220);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 7;
            label7.Text = "Tổng tiền: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 115);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 6;
            label6.Text = "Nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 47);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "Khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 4;
            label4.Text = "Thông tin hóa đơn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 768);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGioHang).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvHoaDon;
        private Panel panel2;
        private DataGridView dgvGioHang;
        private Panel panel3;
        private DataGridView dgvSanPham;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label9;
        private Label lbTongTien;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnThemHoaDon;
        private Button btnCapNhatGioHang;
        private Button btnXoaChiTietDonHang;
        private Button btnTimKiemSP;
        private TextBox txtTimKiem;
        private Button button2;
        private Button button1;
        private TextBox txtSoTienKhachDua;
        private ComboBox cbbNhanVien;
        private ComboBox cbbKhachHang;
        private Label lbTienTraLai;
        private Label label10;
    }
}
