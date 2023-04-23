using Microsoft.VisualStudio.TestTools.UnitTesting;
using Breads.Models;
using System.Collections.Generic;
using System;

namespace BreadTests.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void GetAmt_ReturnAmt_int()
    {
      int amt = 3;
      Bread bread = new Bread(amt);
      int ClassAmt = bread.Quantity;
      Assert.AreEqual(amt, ClassAmt);
    }
  }
}
