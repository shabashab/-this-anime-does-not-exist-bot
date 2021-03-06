namespace ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators.IntegerNumbersCountValidator
{
  public class IntegerNumbersCountValidator : BaseIntegerNumbersCountValidator
  {
    public IntegerNumbersCountValidator(int numbersCount) : base(numbersCount)
    { } 
    
    public override bool Validate(int inputValue)
    {
      int numbersCount = 0;

      do
      {
        inputValue /= 10;
        numbersCount++;
      } while (inputValue > 0);
      
      return this.ValidateNumbersCount(numbersCount);
    }
  }
}