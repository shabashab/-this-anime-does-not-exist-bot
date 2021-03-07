using System.Text;
using ThisAnimeDoesNotExistBot.BL.Builders.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders
{
  public class SeedPathBuilder : ISeedPathBuilder
  {
    public string Build(uint seed)
    {
      var builder = new StringBuilder();
      const string format = "/seed{0}.png";

      builder.AppendFormat(format, seed);

      return builder.ToString();
    }
  }
}