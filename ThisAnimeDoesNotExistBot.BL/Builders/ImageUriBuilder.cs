using System;
using System.Text;
using ThisAnimeDoesNotExistBot.BL.Builders.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Builders
{
  public class ImageUriBuilder : IImageUriBuilder
  {
    private readonly IImageUriBaseBuilder _baseBuilder;
    private readonly ICreativityPathBuilder _creativityPathBuilder;
    private readonly ISeedPathBuilder _seedPathBuilder;


    public Uri Build(IGeneratorParameters generatorParameters, IWebPagePath basePagePath)
    {
      string uriString = "";

      uriString += _baseBuilder.Build(basePagePath);
      uriString += _creativityPathBuilder.Build(generatorParameters.CreativityLevel);
      uriString += _seedPathBuilder.Build(generatorParameters.GenerationSeed);
      
      return new Uri(uriString, UriKind.Absolute);
    }

    public ImageUriBuilder(IImageUriBaseBuilder baseBuilder, ICreativityPathBuilder creativityPathBuilder, ISeedPathBuilder seedPathBuilder)
    {
      _baseBuilder = baseBuilder;
      _creativityPathBuilder = creativityPathBuilder;
      _seedPathBuilder = seedPathBuilder;
    }
  }
}