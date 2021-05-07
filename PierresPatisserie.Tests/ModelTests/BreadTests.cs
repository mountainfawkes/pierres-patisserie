using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresPatisserie.Bread;
using System;
using System.Collections.Generic;

namespace PierresPatisserie.Tests
{
  [TestClass]
  public class BreadTests
  {
    // test to verify type of a constructor with two fields for quantity and price (if necessary)
    [TestMethod]
    public void Order_BuildOrderWithBreadQuantity_Order()
    {
      // Act
      Order newOrder = new Order();

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}

// using int breadOrder to gather order input from the user