using ThisAnimeDoesNotExistBot.BL.Types.Interfaces;

namespace ThisAnimeDoesNotExistBot.BL.Types
{
  public class WebPagePath : IWebPagePath
  {
    public string HostName { get; set; }
    public string Domain { get; set; }

    public WebPagePath()
    {
      
    }
    
    public WebPagePath(string hostName, string domain)
    {
      HostName = hostName;
      Domain = domain;
    }
  }
}