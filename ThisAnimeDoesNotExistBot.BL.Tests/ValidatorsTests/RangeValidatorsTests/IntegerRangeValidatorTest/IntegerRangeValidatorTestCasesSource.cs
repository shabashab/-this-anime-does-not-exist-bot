using System;
using System.Collections;
using System.Collections.Generic;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.RangeValidatorsTests.IntegerRangeValidatorTest
{
  public class IntegerRangeValidatorTestCasesSource
  {
    private static Random _random = new Random();

    private static object CreateCase(int min, int max, int value)
    {
      return new object[] {min, max, value};
    }
    
    public static IEnumerable GetLowerCases(int count)
    {
      var cases = new List<object>();
      
      for (int i = 0; i < count; i++)
      {
        int min = _random.Next(1, int.MaxValue - 1);
        int max = min + 1;

        int value = _random.Next(0, min - 1);
        
        cases.Add(CreateCase(min, max, value));
      }

      return cases;
    }

    public static IEnumerable GetHigherCases(int count)
    {
      var cases = new List<object>();

      for (int i = 0; i < count; i++)
      {
        int max = int.MaxValue - 1;
        int min = max - 1;

        int value = _random.Next(max + 1, int.MaxValue);
        
        cases.Add(CreateCase(min, max, value));
      }

      return cases;
    }

    public static IEnumerable GetRightCases(int count)
    {
      var cases = new List<object>();

      for (int i = 0; i < count; i++)
      {
        int min = _random.Next(0, int.MaxValue - 1);
        int max = _random.Next(min + 1, int.MaxValue);

        int value = _random.Next(min, max);
        
        cases.Add(CreateCase(min, max, value));
      }

      return cases;
    }
  }
}
