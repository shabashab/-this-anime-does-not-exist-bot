using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders.Interfaces
{
  public interface ISeedPathBuilder
  {
    string Build(uint seed);
  }
}