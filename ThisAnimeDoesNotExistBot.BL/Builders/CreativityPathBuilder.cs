using System.Text;
using ThisAnimeDoesNotExistBot.BL.Builders.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders
{
  public class CreativityPathBuilder : ICreativityPathBuilder
  {
    public string Build(uint creativity)
    {
      const string format = "/psi-{0}.{1}";
      var builder = new StringBuilder();

      var creativityFirstNumber = creativity / 10;
      var creativityLastNumber = creativity % 10;

      builder.AppendFormat(format, creativityFirstNumber, creativityLastNumber);

      return builder.ToString();
    }
  }
}