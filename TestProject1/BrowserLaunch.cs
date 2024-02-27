using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
public class Tests
{
    [SetUp]
    public void Setup()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://code.visualstudio.com/docs/csharp/testing");
    }

    [Test]
    public void Test1()
    {
        
        Assert.Pass();
    }
}