using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresPatisserie.Bread;
using PierresPatisserie.Pastry;
using System;
using System.Collections.Generic;

namespace PierresPatisserie.Tests
{
  // Tests for BreadOrder class
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

    [TestMethod]
    public void CalculateBreadCost_CalculateCostIfRemainder_BreadCost()
    {
      int breadQuantity = 5;
      int breadPrice = 5;
      BreadOrder newBreadOrder = new BreadOrder(breadQuantity, breadPrice);
      int expectedBreadCost = 4 * 5;
      int breadCost = newBreadOrder.CalculateBreadCost(breadQuantity, breadPrice);
      Assert.AreEqual(expectedBreadCost, breadCost);
    }
  }

  // Tests for Pastry Order class
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrder_CreateInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(0, 0, 0);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PastryOrder_CreatesOrderWithQuantityAndPrice_PastryOrder()
    {
      int pastryQuantity = 1;
      int pastrySinglePrice = 2;
      int pastryTrioPrice = 5;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity, pastrySinglePrice, pastryTrioPrice);
      Assert.AreEqual(pastryTrioPrice, newPastryOrder.PastryTrioPrice);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfOnePastry_PastryCost()
    {
      int pastryQuantity = 1;
      int pastrySinglePrice = 2;
      int pastryTrioPrice = 5;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity, pastrySinglePrice, pastryTrioPrice);
      int pastryCost = newPastryOrder.CalculatePastryCost(pastryQuantity, pastrySinglePrice, pastryTrioPrice);
      Assert.AreEqual(pastrySinglePrice, pastryCost);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfThreePastries_PastryCost()
    {
      int pastryQuantity = 3;
      int pastrySinglePrice = 2;
      int pastryTrioPrice = 5;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity, pastrySinglePrice, pastryTrioPrice);
      int pastryCost = newPastryOrder.CalculatePastryCost(pastryQuantity, pastrySinglePrice, pastryTrioPrice);
      Assert.AreEqual(pastryTrioPrice, pastryCost);
    }

    [TestMethod]
    public void CalculatePastryCost_CalculatesCostOfFourPastries_PastryCost()
    {
      // Arrange
      int pastryQuantity = 4;
      int pastrySinglePrice = 2;
      int pastryTrioPrice = 5;
      PastryOrder newPastryOrder = new PastryOrder(pastryQuantity, pastrySinglePrice, pastryTrioPrice);

      // Act
      int expectedPastryCost = (3 / 3 * 5) + (1 * 2);
      int pastryCost = newPastryOrder.CalculatePastryCost(pastryQuantity, pastrySinglePrice, pastryTrioPrice);

      // Assert
      Assert.AreEqual(expectedPastryCost, pastryCost);
    }
  }
}

// using int breadOrder to gather order input from the user