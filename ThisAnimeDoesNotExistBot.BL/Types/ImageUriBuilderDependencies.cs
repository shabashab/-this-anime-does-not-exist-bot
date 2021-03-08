using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;
using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Types
{
  public class ImageUriBuilderDependencies : IImageUriBuilderDependencies 
  {
    public ICreativityPathBuilder CreativityPathBuilder { get; }
    public ISeedPathBuilder SeedPathBuilder { get; }
    public IImageUriBaseBuilder ImageUriBaseBuilder { get; }

    public ImageUriBuilderDependencies(ICreativityPathBuilder creativityPathBuilder, ISeedPathBuilder seedPathBuilder, IImageUriBaseBuilder imageUriBaseBuilder)
    {
      CreativityPathBuilder = creativityPathBuilder;
      SeedPathBuilder = seedPathBuilder;
      ImageUriBaseBuilder = imageUriBaseBuilder;
    }
  }
}