using System;

namespace ThisAnimeDoesNotExistBot.BL.Validators
{
  public class HostNameValidator : IHostNameValidator
  {
    public bool Validate(string inputValue)
    {
      try
      {
        var uri = new Uri(inputValue);
        return true;
      }
      catch (UriFormatException e)
      {
        return false;
      }
    }
  }
}