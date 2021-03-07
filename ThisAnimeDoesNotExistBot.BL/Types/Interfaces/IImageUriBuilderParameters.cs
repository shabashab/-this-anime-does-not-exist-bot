namespace ThisAnimeDoesNotExistBot.BL.Types.Interfaces
{
  public interface IImageUriBuilderParameters
  {
    IGeneratorParameters GeneratorParameters { get; }
    string HostName { get; } 
    string Domain { get; }
  }
}