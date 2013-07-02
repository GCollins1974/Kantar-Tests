using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support;
using System.Drawing;
using OpenQA.Selenium.Support.UI;


namespace Kantar
{
    [TestClass]
    public class UnitTest1
    {
        static FirefoxDriver ffd = new FirefoxDriver();
        static ChromeDriver chd = new ChromeDriver();
        static InternetExplorerDriver ied = new InternetExplorerDriver();

        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InFirefox()
        {
            CheckTitleUK(ffd);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InChrome()
        {
            CheckTitleUK(chd);
        }



        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_1()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_2()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_3()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_4()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_5()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_6()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_7()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_8()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_9()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_UK_Title_isCorrect_InIE9_10()
        {
            CheckTitleUK(ied);
        }
        [TestMethod]
        public void Kantar_Home_US_Title_isCorrect_InFirefox()
        {
            CheckTitleUS(ffd);
        }
        [TestMethod]
        public void Kantar_Home_US_Title_isCorrect_InChrome()
        {
            CheckTitleUS(chd);
        }
        [TestMethod]
        public void Kantar_Home_CN_Title_isCorrect_InChrome()
        {
            CheckTitleCN(chd);
        }
        [TestMethod]
        public void Kantar_Home_CN_Title_isCorrect_InFirefox()
        {
            CheckTitleCN(ffd);
        }
        [TestMethod]
        public void Kantar_Home_CN_EN_Title_isCorrect_InFirefox()
        {
            CheckTitleCN_EN(ffd);
        }
        [TestMethod]
        public void Kantar_Home_CN_EN_Title_isCorrect_InChrome()
        {
            CheckTitleCN_EN(chd);
        }
        [TestMethod]
        public void Kantar_Home_Menu_Contains_Correct_HomeLink_InFirefox()
        {
            HomeMenuContainsTextUK(ffd);
            HomeMenuContainsTextCN(ffd);
            HomeMenuContainsTextUS(ffd);
            HomeMenuContainsTextCN_EN(ffd);
        }

        [TestMethod]
        public void Kantar_Home_Menu_Contains_Correct_HomeLink_InChrome()
        {
            HomeMenuContainsTextUK(chd);
            HomeMenuContainsTextCN(chd);
            HomeMenuContainsTextUS(chd);
            HomeMenuContainsTextCN_EN(chd);
        }
        [TestMethod]
        public void MenuHasCorrectFontinFirefox()
        {
            CheckMenuFontUK(ffd);
            CheckMenuFontCN(ffd);
            CheckMenuFontCN_EN(ffd);
            CheckMenuFontUS(ffd);
        }
        [TestMethod]
        public void MenuHasCorrectFontinChrome()
        {
            CheckMenuFontUK(chd);
            CheckMenuFontCN(chd);
            CheckMenuFontCN_EN(chd);
            CheckMenuFontUS(chd);
        }
        public void HomeMenuContainsTextUK(IWebDriver driver)
        {
            driver.Url = "http://uk.kantar.stage.guardianprofessional.co.uk/";
            String strExpectedText = "HOME";
            String actualText = driver.FindElement(By.CssSelector("html body.uk form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected")).Text;
            Assert.AreEqual(strExpectedText, actualText);
        }
        public void HomeMenuContainsTextCN(IWebDriver driver)
        {
            driver.Url = "http://cn.kantar.stage.guardianprofessional.co.uk/";
            String strExpectedText = "首页";
            String actualText = driver.FindElement(By.CssSelector("html body.cn form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a")).Text;
            //html body.cn form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected CSS path for actual homepage above is the login page
            Assert.AreEqual(strExpectedText, actualText);
        }
        public void HomeMenuContainsTextUS(IWebDriver driver)
        {
            driver.Url = "http://us.kantar.stage.guardianprofessional.co.uk/";
            String strExpectedText = "HOME";
            String actualText = driver.FindElement(By.CssSelector("html body.us form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected")).Text;
            Assert.AreEqual(strExpectedText, actualText);
        }
        public void HomeMenuContainsTextCN_EN(IWebDriver driver)
        {
            driver.Url = "http://cn-en.kantar.stage.guardianprofessional.co.uk/";
            String strExpectedText = "HOME - CN-EN";
            String actualText = driver.FindElement(By.CssSelector("html body.cn-en form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected")).Text;
            Assert.AreEqual(strExpectedText, actualText);
        }
        public void CheckTitleUK(IWebDriver driver)
        {


            if ((driver.GetType().Name == "internetexplorerdriver"))
            {
                //driver.Navigate().GoToUrl("http://uk.kantar.stage.guardianprofessional.co.uk/");
                //System.Threading.Thread.Sleep(60000);
                //WebDriverWait wait = new WebDriverWait(ied, TimeSpan.FromSeconds(10));
                //String actualText = driver.FindElement(By.CssSelector("html body.uk form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected")).Text;
                //wait.Until(a => actualText = "HOME");
                IWebElement we = FindElement(driver, By.CssSelector("html body.uk form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected"), 10);
           
            }
            else
            { driver.Url = "http://uk.kantar.stage.guardianprofessional.co.uk/"; }

            String StrExpectedTitle = "Home - Kantar";
            String actualtitle = driver.Title;
            Assert.AreEqual(StrExpectedTitle, actualtitle);
        }
        public void CheckTitleUS(IWebDriver driver)
        {
            driver.Url = "http://us.kantar.stage.guardianprofessional.co.uk/";
            String actualtitle = driver.Title;
            String StrExpectedTitle = "Home - US - Kantar"; //This is currently what it is incorrectly obviously. Once site has content it can be changed and then will need to be updated here.
            Assert.AreEqual(StrExpectedTitle, actualtitle);
        }
        public void CheckTitleCN(IWebDriver driver)
        {
            driver.Url = "http://cn.kantar.stage.guardianprofessional.co.uk/";
            String actualtitle = driver.Title;
            String StrExpectedTitle = "首页 - Kantar";//if site redirects to login page this string will need updating
            Assert.AreEqual(StrExpectedTitle, actualtitle);
        }
        public void CheckTitleCN_EN(IWebDriver driver)
        {
            driver.Url = "http://cn-en.kantar.stage.guardianprofessional.co.uk/";
            String actualtitle = driver.Title;
            String StrExpectedTitle = "China English - Kantar";
            Assert.AreEqual(StrExpectedTitle, actualtitle);
        }
        public void CheckMenuFontUK(IWebDriver driver)
        {
            //if((driver.GetType().Name == "FirefoxDriver"))
            //{
            //    driver.Url = "http://uk.kantar.stage.guardianprofessional.co.uk/";
            //    var ActualFont = ((FirefoxDriver)driver).ExecuteScript("var elem=document.querySelector('html body.uk form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected'); return getComputedStyle(elem, null).getPropertyValue('font-family')");
            //    Assert.IsTrue(ActualFont.ToString().Contains("dinotregular"));
            //    var ActualFontsize = ((FirefoxDriver)driver).ExecuteScript("var elem=document.querySelector('html body.uk form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected'); return getComputedStyle(elem, null).getPropertyValue('font-size')");
            //    String ExpectedFont = "15.95px";
            //    Assert.AreEqual(ActualFontsize.ToString(), ExpectedFont);

            //}
            driver.Url = "http://uk.kantar.stage.guardianprofessional.co.uk/";
            IWebElement home;
            home = driver.FindElement(By.CssSelector("html body.uk form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected"));

            string actualfont = home.GetCssValue("font-family");
            Assert.IsTrue(actualfont.Contains("dinotregular"));
            String expectedfontsize;
            if ((driver.GetType().Name == "FirefoxDriver"))
            {
                expectedfontsize = "15.95px";
            }
            else if ((driver.GetType().Name == "ChromeDriver"))
            {
                expectedfontsize = "16px";
            }
            else
            {
                expectedfontsize = "10pt";
            }
            string actfontsize = home.GetCssValue("font-size");
            Assert.AreEqual(expectedfontsize, actfontsize);
        }
        public void CheckMenuFontCN(IWebDriver driver)
        {
            driver.Url = "http://cn.kantar.stage.guardianprofessional.co.uk/";
            IWebElement home;
            home = driver.FindElement(By.CssSelector("html body.cn form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a"));
            //html body.cn form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected CSS path for actual homepage above is the login page
            string actualfont = home.GetCssValue("font-family");
            Assert.IsTrue(actualfont.Contains("Microsoft Yahei"));
            String expectedfontsize;
            if ((driver.GetType().Name == "FirefoxDriver"))
            {
                expectedfontsize = "15.95px";
            }
            else if ((driver.GetType().Name == "ChromeDriver"))
            {
                expectedfontsize = "16px";
            }
            else
            {
                expectedfontsize = "10pt";
            }
            string actfontsize = home.GetCssValue("font-size");
            Assert.AreEqual(expectedfontsize, actfontsize);
        }
        public void CheckMenuFontCN_EN(IWebDriver driver)
        {
            driver.Url = "http://cn-en.kantar.stage.guardianprofessional.co.uk/";
            IWebElement home;
            home = driver.FindElement(By.CssSelector("html body.cn-en form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected"));
            string actualfont = home.GetCssValue("font-family");
            Assert.IsTrue(actualfont.Contains("dinotregular"));
            String expectedfontsize;
            if ((driver.GetType().Name == "FirefoxDriver"))
            {
                expectedfontsize = "15.95px";
            }
            else if ((driver.GetType().Name == "ChromeDriver"))
            {
                expectedfontsize = "16px";
            }
            else
            {
                expectedfontsize = "10pt";
            }
            string actfontsize = home.GetCssValue("font-size");
            Assert.AreEqual(expectedfontsize, actfontsize);
        }
        public void CheckMenuFontUS(IWebDriver driver)
        {
            driver.Url = "http://us.kantar.stage.guardianprofessional.co.uk/";
            IWebElement home;
            home = driver.FindElement(By.CssSelector("html body.us form#Form1 div#whiteBackground div#mainContainer div#mainNavigationContainer ul.firstLevelMenu li.first a.selected"));
            string actualfont = home.GetCssValue("font-family");
            Assert.IsTrue(actualfont.Contains("dinotregular"));
            String expectedfontsize;
            if ((driver.GetType().Name == "FirefoxDriver"))
            {
                expectedfontsize = "15.95px";
            }
            else if ((driver.GetType().Name == "ChromeDriver"))
            {
                expectedfontsize = "16px";
            }
            else
            {
                expectedfontsize = "10pt";
            }
            string actfontsize = home.GetCssValue("font-size");
            Assert.AreEqual(expectedfontsize, actfontsize);
        }

        public static IWebElement FindElement(IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
        [ClassCleanup()]
        public static void ClassCleanup()
        {
            ffd.Quit();
            chd.Quit();
            // ied.Quit();
        }

    }
}
