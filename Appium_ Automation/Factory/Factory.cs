using Appium__Automation.TestCases.AndroidApps.AZappgame;
using Appium__Automation.TestCases.AndroidApps.BigBasket;
using Appium__Automation.TestCases.AndroidApps.Healthify;
namespace Appium__Automation.TestCases.NativeApps
{
    public class Facotory
    {
        public ITestCase GetTestCase(TestCases testcase)
        {
            if (testcase == TestCases.ContactsCall)
            {
                return new ContactsCall();
            }
            else if (testcase == TestCases.HealthyFiMe)
            {
                return new HealthyFiMe();
            }
            else if (testcase == TestCases.Calculator)
            {
                return new Calculator();
            }
            else if (testcase == TestCases.BigBasketFunctionalities)
            {
                return new BigBasketFunctionalities();
            }
            else if (testcase == TestCases.AndroidSeetings)
            {
                return new AndroidSeetings();
            }
            else if (testcase == TestCases.AzAppgame)
            {
                return new AZappFunctionality();
            }
            else if (testcase == TestCases.MRGame)
            {
                return new MLFunctionality();
            }
            else if (testcase == TestCases.CodeCov)
            {
                return new CodeCov();
            }
            else
            {
                return null;
            }
        }
    }
}
