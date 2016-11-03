using System;
using NUnit.Framework;
using Core;

namespace UnitTests
{
	[TestFixture]
	public class UnitTest1
	{
		[Test]
		public void TestMethod1()
		{
			var mngr = new Manager();
			Assert.IsTrue(mngr.IsValid(10), "Text is valid");
			
		}
	}
}
