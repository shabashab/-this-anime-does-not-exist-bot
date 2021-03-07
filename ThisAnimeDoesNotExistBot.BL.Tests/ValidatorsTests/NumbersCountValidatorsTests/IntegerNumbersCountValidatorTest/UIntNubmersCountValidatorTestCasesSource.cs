using System;
using System.Collections;
using System.Collections.Generic;

namespace ThisAnimeDoesNotExistBot.BL.Tests.ValidatorsTests.NumbersCountValidatorsTests.IntegerNumbersCountValidatorTest
{
  public class UIntNubmersCountValidatorTestCasesSource
  {
    private static Random _random = new Random();

    private static uint NextRandomUint(uint min, uint max)
    {
      int minInt = (int)((long)min + (long)int.MinValue);
      int maxInt = (int)((long)max + (long)int.MinValue);

      int result = _random.Next(minInt, maxInt);
      return (uint) ((long) result + (long) int.MinValue);
    }
    
    private static uint GenerateRandomNumbersCount(uint minValue)
    {
      uint maxValue = 9;
      return NextRandomUint(minValue, maxValue);
    }

    private static uint GenerateNumberWithHigherNumbersCount(uint numbersCount)
    {
      uint min = (uint) Math.Pow(10, numbersCount);
      uint max = uint.MaxValue;
      return NextRandomUint(min, max);
    }

    private static uint GenerateNumberWithLowerNumbersCount(uint numbersCount)
    {
      uint min = uint.MinValue;
      uint max = ((uint) Math.Pow(10, numbersCount - 1)) - 1;
      return NextRandomUint(min, max);
    }

    private static uint GenerateRightNumber(uint numbersCount)
    {
      uint min = (uint) Math.Pow(10, numbersCount - 1);
      uint max = (uint) Math.Pow(10, numbersCount) - 1;
      return NextRandomUint(min, max);
    }

    private static object CreateCase(uint numbersCount, uint number)
    {
      return new object[] {numbersCount, number};
    }
    
    public static IEnumerable GetHigherCases(int count)
    {
      var cases = new List<object>();
      
      for (var i = 0; i < count; i++)
      {
        var numbersCount = GenerateRandomNumbersCount(0);
        var number = GenerateNumberWithHigherNumbersCount(numbersCount);
        cases.Add(CreateCase(numbersCount, number));
      }
      
      return cases; 
    }

    public static IEnumerable GetLowerCases(int count)
    {
      var cases = new List<object>();

      for (var i = 0; i < count; i++)
      {
        var numbersCount = GenerateRandomNumbersCount(2);
        var number = GenerateNumberWithLowerNumbersCount(numbersCount);
        
        cases.Add(CreateCase(numbersCount, number));
      }

      return cases;
    }

    public static IEnumerable GetRightCases(int count)
    {
      var cases = new List<object>();

      for (var i = 0; i < count; i++)
      {
        var numbersCount = GenerateRandomNumbersCount(1);
        var number = GenerateRightNumber(numbersCount);
        
        cases.Add(CreateCase(numbersCount, number));
      }
      
      return cases;
    }
  }
}