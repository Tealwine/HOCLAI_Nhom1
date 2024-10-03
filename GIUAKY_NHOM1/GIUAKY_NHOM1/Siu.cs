using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIUAKY_NHOM1
{
    public partial class Siu : Form
    {
        public Siu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				int so1 = int.Parse(txtNumb1.Text);
				int so2 = int.Parse(txtNumb2.Text);
				txtKQ.Text = (so1 - so2).ToString();
			}
			catch
			{
				txtKQ.Text = "Lỗi: Nhập số hợp lệ!";
			}
		}
	}
}
