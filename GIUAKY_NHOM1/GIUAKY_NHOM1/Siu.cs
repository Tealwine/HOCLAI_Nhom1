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

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox và chuyển thành số thực
                double num1 = Convert.ToDouble(txtSo1.Text);
                double num2 = Convert.ToDouble(txtSo2.Text);

                // Kiểm tra điều kiện chia cho 0
                if (num2 == 0)
                {
                    MessageBox.Show("Lỗi: Không thể chia cho 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Thực hiện phép chia
                    double result = num1 / num2;
                    txtKq.Text = result.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int so1 = int.Parse(txtSo1.Text);
                int so2 = int.Parse(txtSo2.Text);
                txtKq.Text = (so1 - so2).ToString();
            }
            catch
            {
                txtKq.Text = "Lỗi: Nhập số hợp lệ!";
            }
        }


        private void btnNhan_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtSo1.Text);
            double num2 = double.Parse(txtSo2.Text);

            // Thực hiện phép nhân
            double result = num1 * num2;
            txtKq.Text = result.ToString();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ textBox1 và textBox2
                double number1 = double.Parse(txtSo1.Text);
                double number2 = double.Parse(txtSo2.Text);

                // Tính tổng
                double result = number1 + number2;

                // Hiển thị kết quả vào textBox3
                txtKq.Text = result.ToString();
            }
            catch (FormatException)
            {
                // Xử lý lỗi khi giá trị nhập vào không phải là số
                MessageBox.Show("Vui lòng nhập số hợp lệ vào các ô!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
