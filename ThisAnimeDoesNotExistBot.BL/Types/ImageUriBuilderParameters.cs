using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Types
{
  public class ImageUriBuilderParameters : IImageUriBuilderParameters
  {
    public IGeneratorParameters GeneratorParameters { get; }
    public string HostName { get; }
    public string Domain { get; }

    public ImageUriBuilderParameters(IGeneratorParameters generatorParameters, string hostName, string domain)
    {
      GeneratorParameters = generatorParameters;
      HostName = hostName;
      Domain = hostName;
    }
  }
}