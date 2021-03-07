using ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class CreativityLevelValidator : IValidator<uint>
  {
    private readonly IRangeValidator<uint> _rangeValidator;
    
    public CreativityLevelValidator()
    {
      _rangeValidator = new UIntRangeValidator(3, 20);
    } 
    
    public bool Validate(uint inputValue)
    {
      return _rangeValidator.Validate(inputValue);
    }
  }
}