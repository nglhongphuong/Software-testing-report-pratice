using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _11_Phuong_Webdriver
{
    public class TestCase_DangKy_11_phuong
    {
        private string firstName_11_phuong;
        private string lastName_11_phuong;
        private string phone_11_phuong;
        private string email_11_phuong;
        private string password_11_phuong;
        private bool isChecked_11_phuong;

        public TestCase_DangKy_11_phuong(string firstName_11_phuong, 
            string lastName_11_phuong, 
            string phone_11_phuong,
            string email_11_phuong,
            string password_11_phuong,
            bool isChecked_11_phuong)
        {
            this.firstName_11_phuong = firstName_11_phuong;
            this.lastName_11_phuong = lastName_11_phuong;
            this.phone_11_phuong = phone_11_phuong;
            this.email_11_phuong = email_11_phuong;
            this.password_11_phuong = password_11_phuong;
            this.isChecked_11_phuong = isChecked_11_phuong;
        }

        public void Execute_11_phuong()
        {
            IWebDriver driver_11_phuong = new ChromeDriver();
            try
            {
                driver_11_phuong.Url = "https://kfcvietnam.com.vn/en/account/register";
                driver_11_phuong.Navigate();

                // Điền thông tin vào form đăng ký
                driver_11_phuong.FindElement(By.Id("firstName")).SendKeys(firstName_11_phuong);
                driver_11_phuong.FindElement(By.CssSelector("[formcontrolname='lastName']")).SendKeys(lastName_11_phuong);
                driver_11_phuong.FindElement(By.Id("phoneNumber")).SendKeys(phone_11_phuong);
                driver_11_phuong.FindElement(By.Id("email")).SendKeys(email_11_phuong);
                driver_11_phuong.FindElement(By.Id("password")).SendKeys(password_11_phuong);

                if (isChecked_11_phuong)
                {
                    driver_11_phuong.FindElement(By.XPath("//*[@id='mat-checkbox-1']/label/div")).Click();
                }
                driver_11_phuong.FindElement(By.XPath("//button[@type='submit']")).Click();

                Console.WriteLine("Đăng ký tài khoản thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đăng ký tài khoản: " + ex.Message);
            }
            finally
            {
                // Đóng trình duyệt sau khi hoàn tất
                //driver_11_phuong.Quit();
            }
        }

    }
}
