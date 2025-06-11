using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBanhangDaMau
{
    public partial class SoLuong : Form
    {
        public int soluong = 0;
        public SoLuong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            try
            {
                soluong = int.Parse(textBox1.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
        }
    }
}
