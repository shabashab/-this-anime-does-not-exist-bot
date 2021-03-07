using System;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders.Interfaces
{
  public interface IImageUriBuilder 
  {
    Uri Build(IGeneratorParameters generatorParameters, IWebPagePath basePagePath);
  }
}