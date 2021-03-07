namespace ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators
{
  public class UIntNumbersCountValidator : INumbersCountValidator<uint>
  {
    public uint ExpectedCount { get; set; }

    public UIntNumbersCountValidator() : this(0)
    {
      
    }
    
    public UIntNumbersCountValidator(uint expectedCount)
    {
      this.ExpectedCount = expectedCount;
    } 
    
    public bool Validate(uint inputValue)
    {
      ushort numbersCount = 0;

      do
      {
        inputValue /= 10;
        numbersCount++;
      } while (inputValue > 0);

      return numbersCount == ExpectedCount;
    }
  }

}