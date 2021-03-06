namespace ThisAnimeDoesNotExistBot.BL
{
  public interface IGeneratorParameters
  {
    int Seed { get; } 
    int CreativityLevel { get; } //From 3 to 20 with step of 1
  }
}