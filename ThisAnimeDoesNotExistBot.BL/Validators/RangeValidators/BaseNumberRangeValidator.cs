namespace ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators
{
  public abstract class BaseNumberRangeValidator<TNumber> : IValidator<TNumber>
  {
    public abstract bool Validate(TNumber inputValue);
  }
}