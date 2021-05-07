using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresPatisserie.Bread;
using System;
using System.Collections.Generic;

namespace PierresPatisserie.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    // test to verify type of a constructor with two fields for quantity and price (if necessary)
    [TestMethod]
    public void BreadOrder_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      // Act
      BreadOrder newBreadOrder = new BreadOrder(5, 1);

      // Assert
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }
  }
}

// using int breadOrder to gather order input from the user