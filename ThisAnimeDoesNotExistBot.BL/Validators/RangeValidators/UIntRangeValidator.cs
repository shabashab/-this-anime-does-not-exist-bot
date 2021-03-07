
using System;

namespace ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators
{
  public class UIntRangeValidator : IRangeValidator<uint>
  {
    public uint MinValue { get; set; }
    public uint MaxValue { get; set; }

    public UIntRangeValidator() : this(0, 0)
    {
      
    }
    
    public UIntRangeValidator(uint minValue, uint maxValue)
    {
      if(minValue > maxValue)
        throw new ArgumentException("Min value can't be higher than max value", nameof(minValue));

      this.MinValue = minValue;
      this.MaxValue = maxValue;
    }
    
    public bool Validate(uint inputValue)
    {
      var isLower = inputValue < MinValue;
      var isHigher = inputValue > MaxValue;

      return (isLower == false) && (isHigher == false);
    }

  }
}