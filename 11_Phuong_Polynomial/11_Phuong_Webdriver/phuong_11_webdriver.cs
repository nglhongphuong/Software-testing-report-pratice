using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace _11_Phuong_Webdriver
{
    public partial class phuong_11_webdriver : Form
    {
        public phuong_11_webdriver()
        {
            InitializeComponent();
        }

        private void browser_11_phuong_Click(object sender, EventArgs e)
        {
            TestCase_DangKy_11_phuong TC1_SaiDinhDangSDT_11_phuong = new TestCase_DangKy_11_phuong(
            "Phuong",        // firstName
            "Nguyen",        // lastName
            "123abc456",     // phoneNumber (sai định dạng)
            "nglhongphuong@gmail.com", // email
            "Phuong123*",    // password
            true             // isChecked (tích checkbox)
             );
            //TC1_SaiDinhDangSDT_11_phuong.Execute_11_phuong();

            TestCase_DangKy_11_phuong TC2_SaiDinhDangEmail_11_phuong = new TestCase_DangKy_11_phuong(
            "Phuong",        // firstName
            "Nguyen",        // lastName
            "12345678",     // phoneNumber
            "nglhongphuong", // email (sai định dạng)
            "Phuong123*",    // password
            true             // isChecked (tích checkbox)
             );
            //TC2_SaiDinhDangEmail_11_phuong.Execute_11_phuong();

            TestCase_DangKy_11_phuong TC3_SaiDinhDangPass_11_phuong = new TestCase_DangKy_11_phuong(
            "Phuong",        // firstName
            "Nguyen",        // lastName
            "1234567891",     // phoneNumber
            "nglhongphuong@gmail.com", // email
            "Phuong12",    // password (Sai định dạng)
            true             // isChecked (tích checkbox)
            );
           // TC3_SaiDinhDangPass_11_phuong.Execute_11_phuong();

                     TestCase_DangKy_11_phuong TC4_NhapTrongThongTin_11_phuong = new TestCase_DangKy_11_phuong(
            "Phuong",        // firstName
            "Nguyen",        // lastName
            "1234567891",     // phoneNumber
            "", // email - trống thông tin
            "",    // password - trống thông tin
            true             // isChecked (tích checkbox)
            );
            //TC4_NhapTrongThongTin_11_phuong.Execute_11_phuong();


            TestCase_DangKy_11_phuong TC5_EmailTonTai_11_phuong = new TestCase_DangKy_11_phuong(
            "Phuong",        // firstName
            "Nguyen",        // lastName
            "1234567891",     // phoneNumber
            "nguyenluhongphuong@gmail.com", // email tồn tại
            "Phuong123*",    // password 
            true             // isChecked (tích checkbox)
            );
            //TC5_EmailTonTai_11_phuong.Execute_11_phuong();

            TestCase_DangKy_11_phuong TC6_DangKyHopLe_11_phuong = new TestCase_DangKy_11_phuong(
            "Phuong",        // firstName
            "Nguyen",        // lastName
            "1234567891",     // phoneNumber
            "nglhongphuong@gmail.com", // email
            "Phuong123*",    // password
             true          // isChecked (tích checkbox)
            );
            //TC6_DangKyHopLe_11_phuong.Execute_11_phuong();

//-------------------------------------------------------------------------------------------


            TestCase_DangNhap_11_phuong TC1_NhapTrongThongTin_11_phuong = new TestCase_DangNhap_11_phuong(
                "nguyenluhongphuong@gmail.com", 
                "" //Nhập trống thông tin
                );
            //TC1_NhapTrongThongTin_11_phuong.Execute_11_phuong();

            TestCase_DangNhap_11_phuong TC2_SaiMKHoacEmail_11_phuong = new TestCase_DangNhap_11_phuong(
                "2251010077phuong@ou.edu.vn",//Nhập email không tồn tại
                "Phuong123*"
                );
            //TC2_SaiMKHoacEmail_11_phuong.Execute_11_phuong();
            TestCase_DangNhap_11_phuong TC3_DangNhapHopLe_11_phuong = new TestCase_DangNhap_11_phuong(
                "nguyenluhongphuong@gmail.com",
                "Phuong123*"
                );
            TC3_DangNhapHopLe_11_phuong.Execute_11_phuong();
        }
    }
}
