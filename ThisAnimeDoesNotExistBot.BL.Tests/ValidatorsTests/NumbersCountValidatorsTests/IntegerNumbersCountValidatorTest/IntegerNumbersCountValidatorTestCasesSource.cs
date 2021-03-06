using System;
using System.Collections;
using System.Collections.Generic;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.NumbersCountValidatorsTests.IntegerNumbersCountValidatorTest
{
  public class IntegerNumbersCountValidatorTestCasesSource
  {
    private static int GenerateRandomNumbersCount(Random random, int minValue)
    {
      int maxValue = 9;
      return random.Next(minValue, maxValue);
    }

    private static int GenerateNumberWithHigherNumbersCount(Random random, int numbersCount)
    {
      int minValue = (int) Math.Pow(10, numbersCount);
      int maxValue = int.MaxValue;
      return random.Next(minValue, maxValue);
    }

    private static int GenerateNumberWithLowerNumbersCount(Random random, int numbersCount)
    {
      int minValue = 0;
      int maxValue = ((int) Math.Pow(10, numbersCount - 1)) - 1;
      return random.Next(minValue, maxValue);
    }

    private static int GenerateRightNumber(Random random, int numbersCount)
    {
      int minValue = (int) Math.Pow(10, numbersCount - 1);
      int maxValue = (int) Math.Pow(10, numbersCount) - 1;
      return random.Next(minValue, maxValue);
    }

    private static object CreateCase(int numbersCount, int number)
    {
      return new object[] {numbersCount, number};
    }
    
    public static IEnumerable GetHigherCases(int count)
    {
      var random = new Random();
      var cases = new List<object>();

      for (int i = 0; i < count; i++)
      {
        int numbersCount = GenerateRandomNumbersCount(random, 0);
        int number = GenerateNumberWithHigherNumbersCount(random, numbersCount);
        cases.Add(CreateCase(numbersCount, number));
      }
      
      return cases; 
    }

    public static IEnumerable GetLowerCases(int count)
    {
      var random = new Random();
      var cases = new List<object>();

      for (int i = 0; i < count; i++)
      {
        int numbersCount = GenerateRandomNumbersCount(random, 2);
        int number = GenerateNumberWithLowerNumbersCount(random, numbersCount);
        
        cases.Add(CreateCase(numbersCount, number));
      }

      return cases;
    }

    public static IEnumerable GetRightCases(int count)
    {
      var random = new Random();
      var cases = new List<object>();

      for (int i = 0; i < count; i++)
      {
        int numbersCount = GenerateRandomNumbersCount(random, 1);
        int number = GenerateRightNumber(random, numbersCount);
        
        cases.Add(CreateCase(numbersCount, number));
      }
      
      return cases;
    }
  }
}