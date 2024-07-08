using System.Runtime.CompilerServices;

namespace ModuleInitialzerExample
{
  internal class FinalModuleInitializer
  {
    [ModuleInitializer]
    public static void FinalInitialize()
    {
      //Here we can ordering/priority as per requirements
      Initializer2.Initialize2();
      Initializer1.Initialize1();
    }
  }
}
