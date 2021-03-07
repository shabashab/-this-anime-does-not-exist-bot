namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public interface IValidator<in TInput>
  {
    bool Validate(TInput inputValue);
  }
}