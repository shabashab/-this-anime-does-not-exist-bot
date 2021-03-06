using ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class CreativityLevelValidator : ICreativityLevelValidator 
  {
    private readonly BaseIntegerRangeValidator _rangeValidator;
    
    public CreativityLevelValidator()
    {
      this._rangeValidator = new IntegerRangeValidator(3, 20);
    } 
    
    public bool Validate(int inputValue)
    {
      return this._rangeValidator.Validate(inputValue);
    }
  }
}