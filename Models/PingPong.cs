using System.Collections.Generic;

namespace PingPong.Models {
  public class Pong {
    public static List<string> ping(int counter)
    {
      List<string> retList = new List<string> {};

      for (int index = 1; index <= counter; index ++)
      {
        if (index % 15 == 0)
        {
          retList.Add("ping-pong");
        }
        else if (index % 5 == 0)
        {
          retList.Add("pong");
        }
        else if (index % 3 == 0)
        {
          retList.Add("ping");
        }
        else
        {
          retList.Add(index.ToString());
        }
      }

      return retList;
    }
  }
}