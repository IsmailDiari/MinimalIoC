using System.Reflection;

using MinimalIoC.Shared;

namespace MinimalIoC.AnyLayer
{
    public class AnyLayerModule : AssemblyScanModule
    {
        protected override Assembly Assembly => Assembly.GetExecutingAssembly();
    }
}
