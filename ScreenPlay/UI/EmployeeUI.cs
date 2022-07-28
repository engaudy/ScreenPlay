using OpenQA.Selenium;

namespace ScreenPlay.UI
{
    public class EmployeeUI
    {
        public static By Form = By.Id("formEmployee");
        public static By NameInput = By.XPath("(//div[@class='form-group']//input[@type='text'])[1]");
        public static By EmailInput = By.XPath("//div[@class='form-group']//input[@type='email']");
        public static By AddressInput = By.XPath("//textarea[@id='address']");
        public static By PhoneInput = By.XPath("//input[@id='phone']");
        public static By AddButton = By.XPath("//input[@id='addButton']");
    }
}
