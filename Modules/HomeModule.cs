using Nancy;
using System;
using RepeatCounter.Objects;

namespace RepeatCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=> View["index.cshtml"];

    }
  }
}
