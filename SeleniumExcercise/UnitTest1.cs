using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace SeleniumExercise
{
    public class UnitTest1
    {
        private readonly IWebDriver _driver = new ChromeDriver(Environment.CurrentDirectory);

        [Fact]
        public void Test1()
        {
        }
    }
}
