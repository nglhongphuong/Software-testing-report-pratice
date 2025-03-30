using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Phuong_Polynomial
{
    public partial class Phuong_11 : Form
    {
        public Phuong_11()
        {
            InitializeComponent();
        }

        private void Phuong_11_Load(object sender, EventArgs e)
        {

        }

        private void caculate_11_phuong_Click(object sender, EventArgs e)
        {
            try
            {
                string num_11_phuong = n_11_phuong.Text.ToString();
                string array_11_phuong = a_11_phuong.Text.ToString();
                Cal_Polynominal_11_phuong poly_11_phuong = new Cal_Polynominal_11_phuong(num_11_phuong, array_11_phuong);
                double r_11_phuong = poly_11_phuong.Execute_11_phuong(x_11_phuong.Text.ToString());
                result_11_phuong.Text = r_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi không xác định: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
