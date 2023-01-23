namespace WebDriverNUnit.Utility
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.Extensions;

    /// <summary>
    /// The screenshot taker.
    /// </summary>
    public static class ScreenshotTaker
    {
        /// <summary>
        /// Takes a screenshot and stores it in the specified location.
        /// </summary>
        /// <param name="directory">The directory.</param>
        /// <param name="testName">The test name.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string TakeScreenshot(IWebDriver Browser, string directory, string testName)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string screenshotFileName =
                string.Format(
                    "{0}_{1}.{2}",
                    testName,
                    DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss"),
                    ImageFormat.Jpeg.ToString().ToLowerInvariant())
                      .Replace("\"", string.Empty)
                      .Replace("\\", string.Empty);

            string screenshotSaveFullPath = Path.Combine(directory, screenshotFileName);

            using (Image screenshot = Image.FromStream(new MemoryStream(Browser.TakeScreenshot().AsByteArray)))
            {
                screenshot.Save(screenshotSaveFullPath);
            }

            return screenshotSaveFullPath;
        }
    }
}
