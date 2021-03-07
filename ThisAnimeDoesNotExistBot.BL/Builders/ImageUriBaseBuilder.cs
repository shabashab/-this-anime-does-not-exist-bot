using System;
using System.Text;
using ThisAnimeDoesNotExistBot.BL.Builders.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders
{
  public class ImageUriBaseBuilder : IImageUriBaseBuilder
  {
    public string Build(IWebPagePath basePath)
    {
      var uriBaseBuilder = new StringBuilder();

      uriBaseBuilder.Append(basePath.HostName);
      uriBaseBuilder.Append(basePath.Domain);

      return uriBaseBuilder.ToString();
    }
  }
}