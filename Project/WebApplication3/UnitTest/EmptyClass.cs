﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MVCUnitTestingDemo;
using MVCUnitTestingDemo.Controllers;
namespace WebApplication3.UnitTest
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void TestDetailsView()
        {
            var controller = new ProductController();
            var result = controller.Details(2) as ViewResult;
            Assert.AreEqual("Details", result.ViewName);

        }
    }
}
