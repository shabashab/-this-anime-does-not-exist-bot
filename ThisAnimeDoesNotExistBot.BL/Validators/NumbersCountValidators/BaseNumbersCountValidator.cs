namespace ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators
{
  public abstract class BaseNumbersCountValidator<TNumber> : IValidator<TNumber>
  {
    private readonly int _numbersCount; 
    
    protected BaseNumbersCountValidator(int numbersCount)
    {
      _numbersCount = numbersCount;
    }
    
    public abstract bool Validate(TNumber inputValue);

    protected bool ValidateNumbersCount(int numbersCount)
    {
      return _numbersCount == numbersCount;
    }
  }
}