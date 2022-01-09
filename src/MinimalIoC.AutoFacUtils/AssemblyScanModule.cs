using System.Reflection;

using Autofac;

namespace MinimalIoC.AutoFacUtils
{
    public abstract class AssemblyScanModule : Autofac.Module
    {
        protected abstract Assembly Assembly { get; }
        protected override void Load(ContainerBuilder builder) =>
            builder.RegisterAssemblyTypes(Assembly)
                   .AsImplementedInterfaces();
    }
}