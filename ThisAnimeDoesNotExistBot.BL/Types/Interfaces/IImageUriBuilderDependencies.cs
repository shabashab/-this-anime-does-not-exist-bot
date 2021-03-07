using ThisAnimeDoesNotExistBot.BL.Builders.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Types.Interfaces
{
  public interface IImageUriBuilderDependencies
  {
    ICreativityPathBuilder CreativityPathBuilder { get; } 
    ISeedPathBuilder SeedPathBuilder { get; }
    IImageUriBaseBuilder ImageUriBaseBuilder { get; }
  }
}