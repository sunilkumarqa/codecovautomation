using Appium__Automation.TestData;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appium__Automation;
using OpenQA.Selenium.Appium.Service;
using System.Threading;
namespace Appium__Automation.TestCases.NativeApps
{
    public class StartUpScript
    {
         public static void Main(string[] args)
         {
             System.Diagnostics.Process process = new System.Diagnostics.Process();
             System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
             startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
             startInfo.FileName = "C:\\Program Files (x86)\\Appium\\node.exe";
             startInfo.Arguments = @"""C:\\Program Files (x86)\\Appium\\node_modules\\appium\\bin\\appium.js"" --address 127.0.0.1 --port 4730 --automation-name Appium --log-no-color";
             process.StartInfo = startInfo;
             process.Start();
             Thread.Sleep(20000);
             Facotory obj = new Facotory();
             ITestCase testcase = obj.GetTestCase(TestCases.CodeCov);
             testcase.Execute();
         }

    }
}
