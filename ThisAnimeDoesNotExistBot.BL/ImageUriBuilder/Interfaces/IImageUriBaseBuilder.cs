using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces
{
  public interface IImageUriBaseBuilder
  {
    string Build(IWebPagePath basePath);
  }
}