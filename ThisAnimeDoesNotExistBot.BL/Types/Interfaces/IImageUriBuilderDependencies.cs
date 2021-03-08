using ThisAnimeDoesNotExistBot.BL.ImageUriBuilder.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Types.Interfaces
{
  public interface IImageUriBuilderDependencies
  {
    ICreativityPathBuilder CreativityPathBuilder { get; } 
    ISeedPathBuilder SeedPathBuilder { get; }
    IImageUriBaseBuilder ImageUriBaseBuilder { get; }
  }
}