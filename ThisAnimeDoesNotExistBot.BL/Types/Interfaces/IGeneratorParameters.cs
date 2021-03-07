namespace ThisAnimeDoesNotExistBot.BL.Types.Interfaces
{
  public interface IGeneratorParameters
  {
    uint GenerationSeed { get; }
    uint CreativityLevel { get; }
  }
}