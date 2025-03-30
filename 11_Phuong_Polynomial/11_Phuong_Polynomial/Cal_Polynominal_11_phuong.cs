using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Phuong_Polynomial
{
    public class Cal_Polynominal_11_phuong
    {
        private int n_11_phuong;
        private List<int> a_11_phuong;
        public Cal_Polynominal_11_phuong(string num_11_phuong, string a_11_phuong)
        {
            //Bước 4.1:
            if (string.IsNullOrWhiteSpace(num_11_phuong) || string.IsNullOrWhiteSpace(a_11_phuong))
            {
                throw new ArgumentException("Không được để trống dữ liệu");
            }
            //Bước 4.2:
            if (!int.TryParse(num_11_phuong, out n_11_phuong) || n_11_phuong <= 0)
            {
                throw new ArgumentException("Bậc đa thức phải là số nguyên dương");
            }

            this.a_11_phuong = ParseCoeffs_11_phuong(a_11_phuong);
        }

        // Phương thức xử lý hệ số người dùng nhập
        private List<int> ParseCoeffs_11_phuong(string input_11_phuong)
        {
            input_11_phuong = input_11_phuong.Trim().Trim(',');
            // Bước 4.3:
            if (input_11_phuong.Any(c_11_phuong => !char.IsDigit(c_11_phuong) && c_11_phuong != ',' && c_11_phuong != '-'))
            {
                throw new ArgumentException("Hệ số phải được nhập cách nhau bằng dấu phẩy và là số nguyên");
            }
            string[] parts_11_phuong = input_11_phuong.Split(',');
            //Bước 4.4: Hệ số rỗng hoặc định dạng sai 
            if (parts_11_phuong.Any(p =>
            {
                string trimmedPart = p.Trim();
                return string.IsNullOrEmpty(trimmedPart) || trimmedPart == "-" || trimmedPart.EndsWith("-");
            }))
            {
                throw new ArgumentException("Danh sách có hệ số rỗng hoặc định dạng sai");
            }
            //Bước 4.5:
            if (parts_11_phuong.Length != n_11_phuong + 1)
            {
                throw new ArgumentException("Số lượng hệ số không hợp lệ");
            }
            List<int> coeffList_11_phuong = new List<int>();
            foreach (string part_11_phuong in parts_11_phuong)
            {
                coeffList_11_phuong.Add(int.Parse(part_11_phuong.Trim()));
            }
            return coeffList_11_phuong;
        }
        public double Execute_11_phuong(string xInput_11_phuong)
        {
            //Bước 4.1:
            if (string.IsNullOrWhiteSpace(xInput_11_phuong))
            {
                throw new ArgumentException("Không được để trống dữ liệu");
            }
            //Bước 4.6:
            if (!int.TryParse(xInput_11_phuong, out int x_11_phuong))
            {
                throw new ArgumentException("Giá trị x phải là số nguyên");
            }

            double result_11_phuong = 0;
            for (int i_11_phuong = 0; i_11_phuong <= n_11_phuong; i_11_phuong++)
            {
                result_11_phuong += a_11_phuong[i_11_phuong] * Math.Pow(x_11_phuong, i_11_phuong);
            }
            return result_11_phuong;
        }
    }
}
