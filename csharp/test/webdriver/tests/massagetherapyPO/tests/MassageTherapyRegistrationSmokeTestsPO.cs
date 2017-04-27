using csharp.test.webdriver.tests.massagetherapyPO.pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp.test.webdriver.tests.massagetherapyPO.tests
{
    class MassageTherapyRegistrationSmokeTestsPO : BaseTest
    {
        [Test]
        public void FullNameWithAddressPositivePOTest() {
            new FormPage(driver)
                .FillFirstAndMiddleAndLastNamesAs("Maxim", "Mihalych", "Makhnyk")
                .FillStreet1AndStreet2AddressesAs("Mayakovskogo", "91")
                .FillCityAndStateAs("Kiev", "Kievskaya")
                .FillPostalCodeAndCountryAs("02232", "Ukraine")
                .SubmitFormData()
                .AssertConfirmationPageDisplayed();
            Thread.Sleep(3000);
        }
    }
}
