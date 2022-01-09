using System;
using System.IO;
using System.Linq;
using System.Reflection;

using Autofac;
using Autofac.Core;

namespace MinimalIoC.Shared
{
    public static class ContainerBuilderExtensions
    {
        public static void RegisterAutoFacModules(this ContainerBuilder builder)
        {
            const string AssembliesFetchPattern = "MinimalIoC.*.dll";

            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (string.IsNullOrWhiteSpace(path))
                return;
            Directory
                .GetFiles(path, AssembliesFetchPattern, SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom)
                .ToList()
                .ForEach(assembly =>
                {
                    assembly.GetTypes()
                            .Where(p => typeof(IModule).IsAssignableFrom(p) && !p.IsAbstract)
                            .Select(p => (IModule)Activator.CreateInstance(p))
                            .ToList()
                            .ForEach(module => builder.RegisterModule(module));
                });
        }
    }
}
