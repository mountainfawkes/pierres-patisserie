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
      int breadQuantity = 1;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);
      Assert.AreEqual(breadPrice, newBreadOrder.BreadPrice);
    }

    [TestMethod]
    public void CalculateBreadCost_CalculateCostOfOneLoaf_BreadCost()
    {
      int breadQuantity = 1;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);
      int expectedBreadCost = 1 * 5;
      int breadCost = newBreadOrder.CalculateBreadCost(breadQuantity, breadPrice);
      Assert.AreEqual(expectedBreadCost, breadCost);
    }

    [TestMethod]
    public void CalculateBreadCost_CalculateCostOfThreeLoaves_BreadCost()
    {
      int breadQuantity = 3;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);
      int expectedBreadCost = 2 * 5;
      int breadCost = newBreadOrder.CalculateBreadCost(breadQuantity, breadPrice);
      Assert.AreEqual(expectedBreadCost, breadCost);
    }

    [TestMethod]
    public void CalculateBreadCost_CalculateCostOfFourLoaves_BreadCost()
    {
      int breadQuantity = 4;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);
      int expectedBreadCost = 3 * 5;
      int breadCost = newBreadOrder.CalculateBreadCost(breadQuantity, breadPrice);
      Assert.AreEqual(expectedBreadCost, breadCost);
    }

    
  }
}

// using int breadOrder to gather order input from the user