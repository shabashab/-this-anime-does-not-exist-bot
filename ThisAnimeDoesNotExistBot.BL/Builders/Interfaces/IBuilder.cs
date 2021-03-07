namespace ThisAnimeDoesNotExistBot.BL.Builders.Interfaces
{
  public interface IBuilder<out T>
  {
    T Build();
  }
}