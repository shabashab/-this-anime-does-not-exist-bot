using System;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class HostNameValidator : IValidator<string>
  {
    public bool Validate(string inputValue)
    {
      try
      {
        var uri = new Uri(inputValue);
        return true;
      }
      catch (UriFormatException)
      {
        return false;
      }
    }
  }
}