using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders.Interfaces
{
  public interface IImageUriBaseBuilder
  {
    string Build(IWebPagePath basePath);
  }
}