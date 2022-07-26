﻿using OpenQA.Selenium;
using ScreenPlay.Actions;
using ScreenPlay.UI;

namespace ScreenPlay.Tasks
{
    public class AddEmployee
    {
        public static void WithData(IWebDriver driver,string name, string email, string address, string phone)
        {
            Enter.Text(driver, EmployeeUI.NameInput, name);
            Enter.Text(driver, EmployeeUI.EmailInput, email);
            Enter.Text(driver, EmployeeUI.AddressInput, address);
            Enter.Text(driver, EmployeeUI.PhoneInput, phone);
            Click.On(driver, EmployeeUI.AddButton);
        }
        

    }
}
