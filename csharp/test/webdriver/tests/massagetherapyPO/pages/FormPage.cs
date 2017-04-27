using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagetherapyPO.pages
{
    class FormPage : AbstractPage
    {
        IWebElement webElement;

        By firstNameInput = By.XPath(".//input[contains(@id,'first')]");
        By middleNameInput = By.XPath(".//input[contains(@id,'middle')][@type='text']");
        By lastNameInput = By.XPath(".//*[@data-type='control_fullname']//*[contains(text(),'Last Name')]/preceding-sibling::input");
        By streetAddressLine1Input = By.XPath(".//*[@class='form-address-table']//*[contains(@name,'addr_line1')]");
        By streetAddressLine2Input = By.XPath(".//*[@class='form-address-table']//*[contains(@name,'addr_line2')]");
        By cityNameInput = By.CssSelector(".form-address-table input[id$='city']");
        By stateProvinceInput = By.CssSelector(".form-address-table .form-address-state");
        By postalZipCodeInput = By.CssSelector(".form-address-table .form-address-postal");
        By countryDDL = By.CssSelector(".form-address-table .form-address-country");
        By submitButton = By.CssSelector("*[type='submit']");

        public FormPage(IWebDriver driver) : base (driver) {}

        public FormPage FillFirstAndMiddleAndLastNamesAs(String firstName, String middleName, String lastName) {
            SetValueToTextField(firstName, firstNameInput);
            SetValueToTextField(middleName, middleNameInput);
            SetValueToTextField(lastName, lastNameInput);
            return this;
        }

        public FormPage FillStreet1AndStreet2AddressesAs(string streetLine1Name, string streetLine2Name)
        {
            SetValueToTextField(streetLine1Name, streetAddressLine1Input);
            SetValueToTextField(streetLine2Name, streetAddressLine2Input);
            return this;
        }

        public FormPage FillCityAndStateAs(String cityName, String stateName) {
            SetValueToTextField(cityName, cityNameInput);
            SetValueToTextField(stateName, stateProvinceInput);
            return this;
        }

        public FormPage FillPostalCodeAndCountryAs(String postalCode, String country) {
            SetValueToTextField(postalCode, postalZipCodeInput);
            SelectTextFromDropDownList(country, countryDDL);
            return this;
        }

        public ThankYouPage SubmitFormData() {
            ClickOn(submitButton);
            return new ThankYouPage(driver);
        }
    }
}
