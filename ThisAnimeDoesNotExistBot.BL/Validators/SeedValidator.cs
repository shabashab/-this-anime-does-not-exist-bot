using ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators.IntegerNumbersCountValidator;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class SeedValidator : ISeedValidator 
  {
    private readonly IValidator<int> _numbersCountValidator; 
    
    public SeedValidator()
    {
      _numbersCountValidator = new IntegerNumbersCountValidator(5);
    }
    
    public bool Validate(int inputValue)
    {
      return this._numbersCountValidator.Validate(inputValue);
    }
  }
}