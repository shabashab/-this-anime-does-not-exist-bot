namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class EmptyValidator : IValidator<object>
  {
    public bool Validate(object inputValue)
    {
      return true;
    }
  }
}