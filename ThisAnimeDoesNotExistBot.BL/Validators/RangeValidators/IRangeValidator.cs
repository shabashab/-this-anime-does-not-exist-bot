namespace ThisAnimeDoesNotExistBot.BL.Validators.RangeValidators
{
  public interface IRangeValidator<T> : IValidator<T>
  {
    T MinValue { get; set; }
    T MaxValue { get; set; }
  }
}