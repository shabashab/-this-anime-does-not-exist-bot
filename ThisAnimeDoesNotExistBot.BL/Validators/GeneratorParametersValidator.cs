using System;
using ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators.IntegerNumbersCountValidator;
using ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class GeneratorParametersValidator : IGeneratorParametersValidator
  {
    private ISeedValidator _seedValidator;
    private ICreativityLevelValidator _creativityLevelValidator;

      public GeneratorParametersValidator(
      ISeedValidator seedValidator,
      ICreativityLevelValidator creativityLevelValidator)
      {
        this._seedValidator = seedValidator;
        this._creativityLevelValidator = creativityLevelValidator;
      }
    
    public bool Validate(IGeneratorParameters inputValue)
    {
      bool isSeedValid = _seedValidator.Validate(inputValue.Seed);
      bool isCreativityLevelValid = _creativityLevelValidator.Validate(inputValue.CreativityLevel);

      return isSeedValid && isCreativityLevelValid;
    }
  }
}