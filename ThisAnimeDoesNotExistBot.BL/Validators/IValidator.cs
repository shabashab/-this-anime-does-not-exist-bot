namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public interface IValidator<TInput>
  {
    bool Validate(TInput inputValue);
  }
}