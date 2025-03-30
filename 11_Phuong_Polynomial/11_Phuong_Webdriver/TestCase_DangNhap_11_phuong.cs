using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace _11_Phuong_Webdriver
{
    public class TestCase_DangNhap_11_phuong
    {
        private string email_11_phuong;
        private string password_11_phuong;

        public TestCase_DangNhap_11_phuong(string email_11_phuong, string password_11_phuong)
        {
            this.email_11_phuong = email_11_phuong;
            this.password_11_phuong = password_11_phuong;
        }

        public void Execute_11_phuong()
        {
            IWebDriver driver_11_phuong = new ChromeDriver();
            try
            {
                driver_11_phuong.Url = "https://kfcvietnam.com.vn/en/account/login";
                driver_11_phuong.Navigate();

                IWebElement emailField_11_phuong = driver_11_phuong.FindElement(By.CssSelector("[formcontrolname='email']"));
                emailField_11_phuong.SendKeys(email_11_phuong);

                IWebElement passwordField_11_phuong = driver_11_phuong.FindElement(By.CssSelector("[type='password']"));
                passwordField_11_phuong.SendKeys(password_11_phuong);

                IWebElement loginButton_11_phuong = driver_11_phuong.FindElement(By.XPath("//app-login//form//app-button/button"));
                loginButton_11_phuong.Click();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đăng nhập: " + ex.Message);
            }
            finally
            {
                // Đóng trình duyệt sau khi hoàn tất
                // driver_11_phuong.Quit();
            }

        }
    }
}
