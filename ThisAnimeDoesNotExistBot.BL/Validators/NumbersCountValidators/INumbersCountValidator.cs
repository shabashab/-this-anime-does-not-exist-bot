namespace ThisAnimeDoesNotExistBot.BL.Validators.NumbersCountValidators
{
  public interface INumbersCountValidator<T> : IValidator<T>
  {
    uint ExpectedCount { get; set; } 
  }
}