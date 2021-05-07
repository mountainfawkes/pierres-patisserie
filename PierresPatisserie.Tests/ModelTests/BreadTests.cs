using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresPatisserie.Bread;
using System;
using System.Collections.Generic;

namespace PierresPatisserie.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrder_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(5, 1);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadOrder_CreatesOrderWithQuantityAndPrice_BreadOrder()
    {
      // Arrange
      int breadQuantity = 1;
      int breadPrice = 5;
      
      // Act
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);

      // Assert
      Assert.AreEqual(breadPrice, newBreadOrder.BreadPrice);
    }

    [TestMethod]
    public void CalculateBreadCost_CalculateCostOfOneLoaf_BreadCost()
    {
      // Arrange
      int breadQuantity = 1;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);

      // Act
      int expectedBreadCost = 5 * 1;
      int breadCost = newBreadOrder.CalculateBreadCost(breadQuantity, breadPrice);

      // Assert
      Assert.AreEqual(expectedBreadCost, breadCost);
    }
  }
}

// using int breadOrder to gather order input from the user