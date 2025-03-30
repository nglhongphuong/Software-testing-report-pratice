using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _11_Phuong_Polynomial;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace UnitTest_11_phuong
{
    [TestClass]
    public class UnitTest1_11_phuong
    {
        private Cal_Polynominal_11_phuong c_phuong_11;
        [TestInitialize]
        public void SetUp_11_phuong()
        {
            c_phuong_11 = new Cal_Polynominal_11_phuong("2", "1,2,3");
        }
        //TestCase1_NhapRong_11_Phuong: n = "", a = "", x = "1" -> kq="Không được để trống dữ liệu"
        [TestMethod]
        public void TestCase1_NhapRong_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "Không được để trống dữ liệu";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("","");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("1");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }
        //TestCase2_BacDaThucKhongHopLe_11_Phuong: n = "a", a = "1,2,3", x = "1" -> kq="Bậc đa thức phải là số nguyên dương"
        [TestMethod]
        public void TestCase2_BacDaThucKhongHopLe_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "Bậc đa thức phải là số nguyên dương";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("a", "1,2,3");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("1");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }

        //TestCase3_DinhDangHeSoSai_11_Phuong  n = "2", a = "1 2 ,3", x = "1" -> kq="Hệ số phải được nhập cách nhau bằng dấu phẩy và là số nguyên"
        [TestMethod]
        public void TestCase3_DinhDangHeSoSai_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "Hệ số phải được nhập cách nhau bằng dấu phẩy và là số nguyên";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("2", "1 2 ,3");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("1");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }

        //TestCase4_HeSoRongHoacSaiDinhDang_11_Phuong  n = "2", a = "1,3-,3", x = "1" -> kq = "Danh sách có hệ số rỗng hoặc định dạng sai"
        [TestMethod]
        public void TestCase4_HeSoRongHoacSaiDinhDang_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "Danh sách có hệ số rỗng hoặc định dạng sai";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("2", "1,3-,3");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("1");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }

        //TestCase5_SoLuongHeSoSai_11_Phuong  n = "2", a = "1,2", x = "1" -> kq="Số lượng hệ số không hợp lệ"
        [TestMethod]
        public void TestCase5_SoLuongHeSoSai_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "Số lượng hệ số không hợp lệ";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("2", "1,2");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("1");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }


        //TestCase6_XKhongHopLe_11_Phuong n = "2", a = "1,2,3", x = "1.2" -> kq = "Giá trị x phải là số nguyên"
        [TestMethod]
        public void TestCase6_XKhongHopLe_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "Giá trị x phải là số nguyên";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("2","1,2,3");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("1.2");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }

        //TestCase7_TinhDaThucHopLe_11_Phuong  n = "2", a = "3,4,5", x = "2" -> kq = "31"
        [TestMethod]
        public void TestCase7_TinhDaThucHopLe_11_Phuong()
        {
            string expected_11_phuong, actual_11_phuong;
            expected_11_phuong = "31";
            try
            {
                c_phuong_11 = new Cal_Polynominal_11_phuong("2", "3,4,5");
                double result_11_phuong = c_phuong_11.Execute_11_phuong("2");
                actual_11_phuong = result_11_phuong.ToString();
            }
            catch (ArgumentException ex)
            {
                actual_11_phuong = ex.Message;
            }
            Assert.AreEqual(expected_11_phuong, actual_11_phuong);
        }


        //TestCase8_DocFileExcel_11_phuong: Đọc file excel để test tập dữ liệu với 5 cột cụ thể n,a,x,kq_mongdoi, kq_test
        [TestMethod]
        public void TestCase8_DocFileExcel_11_phuong()
        {
            string file_11_phuong = @"D:\Nam 3\KTPM\11_Phuong_Polynomial\UnitTest_11_phuong\Data_11_phuong\TestData_Excel_11_phuong.xlsx";
            Application excel_11_phuong = new Application();
            Workbook wb_11_phuong = excel_11_phuong.Workbooks.Open(file_11_phuong, ReadOnly: false);
            Worksheet ws_11_phuong = wb_11_phuong.Worksheets[1];

            int row_11_phuong = ws_11_phuong.UsedRange.Rows.Count;

            Console.WriteLine($"{"STT",-5} {"n_11_phuong",-5} {"a_11_phuong",-10} {"x_11_phuong",-5} {"KQ_ThucTe_11_phuong",-70} {"KQ_Test",-5}");
            Console.WriteLine(new string('-', 150));

            int stt_11_phuong = 1;

            for (int i_11_phuong = 2; i_11_phuong <= row_11_phuong; i_11_phuong++)
            {
                string n_11_phuong = Convert.ToString(ws_11_phuong.Cells[i_11_phuong, 1].Value) ?? "";
                string a_11_phuong = Convert.ToString(ws_11_phuong.Cells[i_11_phuong, 2].Value) ?? "";
                string x_11_phuong = Convert.ToString(ws_11_phuong.Cells[i_11_phuong, 3].Value) ?? "";
                string expectedResult_11_phuong = Convert.ToString(ws_11_phuong.Cells[i_11_phuong, 4].Value) ?? "";
                string passFail_11_phuong = Convert.ToString(ws_11_phuong.Cells[i_11_phuong, 5].Value) ?? ""; ;
                string actualResult_11_phuong = "";

                try
                {
                    c_phuong_11 = new Cal_Polynominal_11_phuong(n_11_phuong, a_11_phuong);
                    double result_11_phuong = c_phuong_11.Execute_11_phuong(x_11_phuong);
                    actualResult_11_phuong = result_11_phuong.ToString();
                }
                catch (ArgumentException ex)
                {
                    actualResult_11_phuong = ex.Message;
                }
                try
                {
                    Assert.AreEqual(expectedResult_11_phuong, actualResult_11_phuong);
                    passFail_11_phuong = passFail_11_phuong == "pass" ? passFail_11_phuong : "pass";
                }
                catch (AssertFailedException ex)
                {
                    passFail_11_phuong = passFail_11_phuong == "fail" ? passFail_11_phuong : "fail";
                }
                Console.WriteLine($"{stt_11_phuong,-5} {n_11_phuong,-10} {a_11_phuong,-20} {x_11_phuong,-1} {actualResult_11_phuong,-63} {passFail_11_phuong,-1}");
                stt_11_phuong++;
            }
            wb_11_phuong.Close(false);
            excel_11_phuong.Quit();
        }


    }
}
