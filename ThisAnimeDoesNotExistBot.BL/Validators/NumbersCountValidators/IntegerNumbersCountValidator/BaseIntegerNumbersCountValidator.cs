using System;

namespace ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators.IntegerNumbersCountValidator
{
  public abstract class BaseIntegerNumbersCountValidator : BaseNumbersCountValidator<int>
  {
    protected BaseIntegerNumbersCountValidator(int numbersCount) : base(numbersCount)
    {
      if(numbersCount > 10)
        throw new ArgumentException("Numbers count should be less than 10", nameof(numbersCount));
    }
  }
}