// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

//open the browser
IWebDriver driver = new ChromeDriver();

//maximize window
driver.Manage().Window.Maximize();


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


//Applying Implicit Wait command for 10 seconds
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

////check if user logged in successfully
//string newURL = driver.Url;
////string newURL1 = driver.currentUrl;
////string newURL2 = driver.getCurrentURL();

//if (newURL == "http://localhost:5000/Account/Profile")
//{
//  Console.WriteLine("User logged in Successfully");
//}
//else
//{
//  Console.WriteLine("Log in unsuccessful");
//Console.WriteLine(newURL);
//}






//check if user logged in successfully
IWebElement ProfileName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
if (ProfileName.Text != null)
{
    Console.WriteLine(ProfileName.Text);
    Console.WriteLine("Login successful!!");
}
else
{
    Console.WriteLine(ProfileName.Text);
    Console.WriteLine("Login Unsuccessful!!");
}



//Create new languages record

//Navigate languages tab
IWebElement languageTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
languageTab.Click();

//Click add new
IWebElement addNewLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
addNewLanguageButton.Click();

//Enter details
IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
addLanguage.SendKeys("lang_test4");

//Applying Implicit Wait command for 10 seconds
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
languageLevel.Click();


IWebElement basicLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
basicLevel.Click();

//Enter add(save) button
IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
addButton.Click();


//Applying Implicit Wait command for 5 seconds
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


//Create new skill record

//Navigate Skill tab
IWebElement SkillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
SkillTab.Click();

//Click add new
IWebElement addNewSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
addNewSkillButton.Click();

//Enter details
IWebElement addSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
addSkill.SendKeys("skill_test2");

//Applying Implicit Wait command for 5 seconds
driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


IWebElement SkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
SkillLevel.Click();


IWebElement expertLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
expertLevel.Click();

//Enter add(save) button
IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
addSkillButton.Click();

