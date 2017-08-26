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
using System.Text.RegularExpressions;
using System.IO;
using OpenQA.Selenium.Support.UI;
using System.Threading;


namespace FacebookFriendRemover
{
    public partial class Form1 : Form
    {
        static IWebDriver driverGC;

        public Form1()
        {
            driverGC = new ChromeDriver(@"Z:\Justin\Documents\Visual Studio 2015\chromedriver_win32");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\Justin\Desktop\newFile.txt", string.Empty);
            int myNewProgress = 0;
            String emailText = Email.Text;
            //MessageBox.Show(emailText);
            String passwordText = Password.Text;
            driverGC.Navigate().GoToUrl("https://www.facebook.com/");
            var emailSpot = driverGC.FindElement(By.Id("email"));
            emailSpot.SendKeys("justinkowalsky@live.com");
            var passwordSpot = driverGC.FindElement(By.Id("pass"));
            passwordSpot.SendKeys("Sharen123abc");
            driverGC.FindElement(By.Id("royal_login_button")).Click();
        }


    }
}
