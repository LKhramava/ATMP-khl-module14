using NUnit.Framework;
using System.Net;
using WebDriverNUnit.Utility;

namespace WebDriverNUnit.WebDriver
{
	public class BaseTestRESTWebService
	{
		protected HttpWebResponse Response { get; set; }
		protected Logger Log;

		public BaseTestRESTWebService()
		{
			this.Log = LoggerManager.GetLogger(this.GetType());
		}

		[SetUp]
		public virtual void InitTest()
		{
			Response = MakeRequest();
		}

		private static HttpWebResponse MakeRequest()
		{
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Configuration.JsonPlaceholderUrl);
			request.Method = "Get";

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			return response;
		}

	}
}
