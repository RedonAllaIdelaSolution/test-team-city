﻿using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Controllers;

namespace UnitTestProject
{
	[TestClass]
	public class UnitTest
	{
		[TestClass]
		public class TestHomeController
		{
			[TestMethod]
			public void TestAboutPage()
			{
				HomeController controller = new HomeController();
				ViewResult result = controller.About() as ViewResult;
				Assert.AreEqual("Should faild test.", result.ViewData["Message"]);
			}
		}
	}
}
