using System;
using System.Collections;
using System.Collections.Generic;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.RangeValidatorsTests.IntegerRangeValidatorTest
{
  public class UIntRangeValidatorTestCasesSource
  {
    private static Random _random = new Random();

    private static object CreateCase(uint min, uint max, uint value)
    {
      return new object[] {min, max, value};
    }
    
    private static uint NextRandomUint(uint min, uint max)
    {
      int minInt = (int)((long)min + (long)int.MinValue);
      int maxInt = (int)((long)max + (long)int.MinValue);

      int result = _random.Next(minInt, maxInt);
      return (uint) ((long) result + (long) int.MinValue);
    }
    
    public static IEnumerable GetLowerCases(int count)
    {
      var cases = new List<object>();
      
      for (var i = 0; i < count; i++)
      {
        var min = NextRandomUint(1, uint.MaxValue - 1);
        var max = min + 1;

        var value = NextRandomUint(uint.MinValue, min - 1);
        
        cases.Add(CreateCase(min, max, value));
      }

      return cases;
    }

    public static IEnumerable GetHigherCases(int count)
    {
      var cases = new List<object>();

      for (var i = 0; i < count; i++)
      {
        var max = NextRandomUint(1, uint.MaxValue - 1);
        var min = max - 1;

        var value = NextRandomUint(max + 1, uint.MaxValue); 
        
        cases.Add(CreateCase(min, max, value));
      }

      return cases;
    }

    public static IEnumerable GetRightCases(int count)
    {
      var cases = new List<object>();

      for (var i = 0; i < count; i++)
      {
        var min = NextRandomUint(0, uint.MaxValue - 1);
        var max = NextRandomUint(min + 1, uint.MaxValue);

        var value = NextRandomUint(min, max);
        
        cases.Add(CreateCase(min, max, value));
      }

      return cases;
    }
  }
}
