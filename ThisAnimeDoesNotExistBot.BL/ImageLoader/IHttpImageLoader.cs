using System;
using System.Drawing;

namespace ThisAnimeDoesNotExistBot.BL
{
  public interface IHttpImageLoader
  {
    Image LoadByUri(Uri uri);
  }
}