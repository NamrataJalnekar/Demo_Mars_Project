// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

//open the browser
IWebDriver driver = new ChromeDriver();


//launch the mars portal and navigate to sign in
driver.Navigate().GoToUrl("http://localhost:5000/Home");
IWebElement SignIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
SignIn.Click();

//identify email address textbox  and enter valid email address
IWebElement userEmail = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
userEmail.SendKeys("jalnekar.namrata@gmail.com");

// identify password textbox and enter valid password
IWebElement userPassword = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
userPassword.SendKeys("abc123");

//identify login button and click on login button
IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginButton.Click();



//check if user logged in successfully
string newURL = driver.Url;

if (newURL == "http://localhost:5000/Account/Profile")
{
    Console.WriteLine("User logged in Successfully");
}
else
{
    Console.WriteLine("Log in unsuccessful");
}

