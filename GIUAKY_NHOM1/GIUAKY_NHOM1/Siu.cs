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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

		private void button3_Click(object sender, EventArgs e)
		{
			double num1 = double.Parse(txt1.Text);
			double num2 = double.Parse(txt2.Text);

			// Thực hiện phép nhân
			double result = num1 * num2;
            txtketqua.Text = result.ToString();
		}
	}
}
