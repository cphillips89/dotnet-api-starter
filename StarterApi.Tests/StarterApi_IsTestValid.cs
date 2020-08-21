
using System;
using StarterApi.Controllers;
using Xunit;

namespace StarterApi.UnitTests.Utility
{
    public class StarterApi_IsTestValid
    { 
      private readonly UtilityController _utilityController;
      public StarterApi_IsTestValid() 
      {
        _utilityController = new UtilityController();
      }

      [Fact]
      public void TestReturnsString() 
      {
        var result = _utilityController.GetTest() == "Success";
        Assert.True(result, $"{result} should be Success");
      }

    }
}