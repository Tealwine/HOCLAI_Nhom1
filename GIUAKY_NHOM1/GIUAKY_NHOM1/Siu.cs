using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            try
            {
                // Lấy giá trị từ textBox1 và textBox2
                double number1 = double.Parse(Sothu1.Text);
                double number2 = double.Parse(Sothu2.Text);

                // Tính tổng
                double result = number1 + number2;

                // Hiển thị kết quả vào textBox3
                ketqua.Text = result.ToString();
            }
            catch (FormatException)
            {
                // Xử lý lỗi khi giá trị nhập vào không phải là số
                MessageBox.Show("Vui lòng nhập số hợp lệ vào các ô!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
