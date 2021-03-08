using System.Text;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.ImageUriBuilder
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