using ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class SeedValidator : IValidator<uint>
  {
    private readonly UIntNumbersCountValidator _numbersCountValidator; 
    
    public SeedValidator()
    {
      _numbersCountValidator = new UIntNumbersCountValidator(5);
    }
    
    public bool Validate(uint inputValue)
    {
      return this._numbersCountValidator.Validate(inputValue);
    }
  }
}