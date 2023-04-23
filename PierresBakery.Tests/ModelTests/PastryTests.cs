using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pastrys.Models;
using System.Collections.Generic;
using System;

namespace PastryTests.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void GetAmt_ReturnAmt_int()
    {
      int amt = 4;
      Pastry pastry = new Pastry(amt);
      int ClassAmt = pastry.Quantity;
      Assert.AreEqual(amt, ClassAmt);
    }

    [TestMethod]
    public void CalcPrice_ReturnPrice_String()
    {
      Pastry pastry = new Pastry(8);
      string Price = pastry.CheckCost();
      Assert.AreEqual("12", Price);
    }
  }
}
