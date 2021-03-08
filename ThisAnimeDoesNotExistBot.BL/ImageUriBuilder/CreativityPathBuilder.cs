using System.Text;
using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.ImageUriBuilder
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