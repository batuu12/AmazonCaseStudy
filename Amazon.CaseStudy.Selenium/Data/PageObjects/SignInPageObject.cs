﻿using System;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Data.PageObjects
{
	public class SignInPageObject
	{
        private readonly IWebDriver webDriver;

        public SignInPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement EmailInput => webDriver.FindElement(By.Id("ap_email"));

        public IWebElement ContinueButton => webDriver.FindElement(By.Id("continue"));

        public IWebElement PasswordInput => webDriver.FindElement(By.Id("ap_password"));

        public IWebElement SignInButton => webDriver.FindElement(By.Id("signInSubmit"));

        public IWebElement BlankEmailWarnMessage => webDriver.FindElement(By.XPath("//div[contains(text(),'E-posta')]"));

        public IWebElement WrongEmailWarnMessage => webDriver.FindElement(By.XPath("//span[contains(text(),'e-posta')]"));

        public IWebElement WrongPasswordMessage => webDriver.FindElement(By.XPath("//span[@class='a-list-item']"));

        public IWebElement BlankPasswordMessage => webDriver.FindElement(By.XPath("//div[contains(text(),'Şifrenizi girin')]"));
    }
}

