
namespace ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators
{
  public class IntegerRangeValidator : BaseIntegerRangeValidator 
  {
    private int _minValue;
    private int _maxValue;
    
    public IntegerRangeValidator(int minValue, int maxValue)
    {
      this._minValue = minValue;
      this._maxValue = maxValue;
    }
    
    public override bool Validate(int inputValue)
    {
      bool isLower = inputValue < _minValue;
      bool isHigher = inputValue > _maxValue;

      return (isLower == false) && (isHigher == false);
    }
  }
}