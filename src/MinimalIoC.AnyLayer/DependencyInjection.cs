using System.Reflection;

using MinimalIoC.AutoFacUtils;

namespace MinimalIoC.AnyLayer
{
    public class AnyLayerModule : AssemblyScanModule
    {
        protected override Assembly Assembly => Assembly.GetExecutingAssembly();
    }
}
