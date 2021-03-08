using System;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces
{
  public interface IImageUriBuilder
  {
    Uri Build(IGeneratorParameters generatorParameters, IWebPagePath basePagePath);
  }
}