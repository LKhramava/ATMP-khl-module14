using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverNUnit.Utility;

namespace WebDriverNUnit.WebDriver
{
	public class BaseTest
	{
		protected static Browser Browser = Browser.Instance;
		protected Logger Log;

		public BaseTest()
		{
			Log = LoggerManager.GetLogger(this.GetType());
		}

		[SetUp]
		public virtual void InitTest()
		{
			Browser = Browser.Instance;
			Browser.WindowMaximise();
			Browser.NavigateTo(Configuration.StartUrl);
		}

		[TearDown]
		public void TestClean()
		{
			if (TestContext.CurrentContext.Result.Outcome == ResultState.Failure)
			{
				ScreenshotTaker.TakeScreenshot(Browser.GetDriver(), Path.Combine(Environment.CurrentDirectory, @"..\..\..\Screenshots"), TestContext.CurrentContext.Test.MethodName);
				Log.Info(string.Format(@"Test {0} is failed and screenshot has been taken.", TestContext.CurrentContext.Test.Name));
			}
			Browser.Quit();
		}
	}
}
