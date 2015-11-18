using System;

using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

namespace Bumblebee.IntegrationTests.Shared.Pages
{
	public class SlowWebPageWithExplicitWait : SlowWebPage
	{
		public SlowWebPageWithExplicitWait(Session session) : base(session, TimeSpan.FromSeconds(10))
		{
		}
	}

	public class SlowWebPageWithNoWait : SlowWebPage
	{
		public SlowWebPageWithNoWait(Session session) : base(session)
		{
		}
	}

	public abstract class SlowWebPage : WebPage
	{
		public SlowWebPage(Session session, TimeSpan? timeout = null)
			: base(session, timeout ?? TimeSpan.FromSeconds(0))
		{
		}

		public ITextField FirstName
		{
			get { return new TextField(this, By.Id("firstName")); }
		}

		public ICheckbox Checkbox
		{
			get { return new Checkbox(this, By.Id("checkedCheckbox"));}
		}
	}
}
