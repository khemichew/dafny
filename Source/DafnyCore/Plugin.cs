using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.Dafny.Plugins;
namespace MutateCSharp
{
    internal class Schemata355
    {
        private static readonly System.Lazy<long> ActivatedMutantId =
          new System.Lazy<long>(() =>
          {
              var activatedMutant = System.Environment.GetEnvironmentVariable("MUTATE_CSHARP_ACTIVATED_MUTANT355");
              return !string.IsNullOrEmpty(activatedMutant) ? long.Parse(activatedMutant) : 0;
          });

        private static bool ActivatedInRange(long lowerBound, long upperBound)
        {
            return lowerBound <= ActivatedMutantId.Value && ActivatedMutantId.Value <= upperBound;
        }
        internal static bool ReplaceBinExprOp_5(long mutantId, Microsoft.Dafny.Plugins.PluginConfiguration argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            return argument1 == argument2;
        }

        internal static string ReplaceStringConstant_3(long mutantId, string argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return string.Empty; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_1(long mutantId, int argument1, int argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 4)) { return argument1 == argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 < argument2; }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1 <= argument2; }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1 > argument2; }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1 >= argument2; }
            return argument1 == argument2;
        }

        internal static bool ReplaceBinExprOp_4(long mutantId, Microsoft.Dafny.Plugins.PluginConfiguration argument1, object argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 0)) { return argument1 != argument2; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 == argument2; }
            return argument1 != argument2;
        }

        internal static int ReplaceNumericConstant_0(long mutantId, int argument1)
        {
            if (!ActivatedInRange(mutantId, mutantId + 3)) { return argument1; }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1 + 1; }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1 - 1; }
            if (ActivatedMutantId.Value == mutantId + 2) { return -argument1; }
            if (ActivatedMutantId.Value == mutantId + 3) { return 0; }
            return argument1;
        }

        internal static bool ReplaceBinExprOp_2(long mutantId, System.Func<bool> argument1, System.Func<bool> argument2)
        {
            if (!ActivatedInRange(mutantId, mutantId + 5)) { return argument1() && argument2(); }
            if (ActivatedMutantId.Value == mutantId + 0) { return argument1() || argument2(); }
            if (ActivatedMutantId.Value == mutantId + 1) { return argument1() | argument2(); }
            if (ActivatedMutantId.Value == mutantId + 2) { return argument1() & argument2(); }
            if (ActivatedMutantId.Value == mutantId + 3) { return argument1() ^ argument2(); }
            if (ActivatedMutantId.Value == mutantId + 4) { return argument1() == argument2(); }
            if (ActivatedMutantId.Value == mutantId + 5) { return argument1() != argument2(); }
            return argument1() && argument2();
        }

    }
}

namespace Microsoft.Dafny
{
    public interface Plugin
    {
        public IEnumerable<IExecutableBackend> GetCompilers(DafnyOptions options);
        public IEnumerable<IRewriter> GetRewriters(ErrorReporter reporter);
        public IEnumerable<DocstringRewriter> GetDocstringRewriters(DafnyOptions options);
        public IEnumerable<CompilerInstrumenter> GetCompilerInstrumenters(ErrorReporter reporter);
    }

    public
    record ErrorPlugin(string AssemblyAndArgument, Exception Exception) : Plugin
    {
        public IEnumerable<IExecutableBackend> GetCompilers(DafnyOptions options)
        {
            return Enumerable.Empty<IExecutableBackend>();
        }

        public IEnumerable<IRewriter> GetRewriters(ErrorReporter reporter)
        {
            return new[] { new ErrorRewriter(reporter, this) };
        }

        public IEnumerable<DocstringRewriter> GetDocstringRewriters(DafnyOptions options)
        {
            return Enumerable.Empty<DocstringRewriter>();
        }

        public IEnumerable<CompilerInstrumenter> GetCompilerInstrumenters(ErrorReporter reporter)
        {
            return Enumerable.Empty<CompilerInstrumenter>();
        }

        public
          class ErrorRewriter : IRewriter
        {
            private readonly ErrorPlugin errorPlugin;

            public ErrorRewriter(ErrorReporter reporter, ErrorPlugin errorPlugin) : base(reporter)
            {
                this.errorPlugin = errorPlugin;
            }

            internal override void PreResolve(Program program)
            {
                program.Reporter.Error(MessageSource.Resolver, Token.NoToken, $"Error while instantiating plugin '{errorPlugin.AssemblyAndArgument}':\n{errorPlugin.Exception}");
                base.PreResolve(program);
            }
        }
    }

    public class ConfiguredPlugin : Plugin
    {
        public PluginConfiguration Configuration { get; }

        public ConfiguredPlugin(PluginConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IEnumerable<IExecutableBackend> GetCompilers(DafnyOptions options)
        {
            return Configuration.GetCompilers(options);
        }

        public IEnumerable<IRewriter> GetRewriters(ErrorReporter reporter)
        {
            return Configuration.GetRewriters(reporter).Select(rewriter => new PluginRewriter(reporter, rewriter));
        }

        public IEnumerable<DocstringRewriter> GetDocstringRewriters(DafnyOptions options)
        {
            return Configuration.GetDocstringRewriters(options);
        }

        public IEnumerable<CompilerInstrumenter> GetCompilerInstrumenters(ErrorReporter reporter)
        {
            return Configuration.GetCompilerInstrumenters(reporter);
        }
    }

    /// <summary>
    /// This class wraps an assembly and an extracted configuration from this assembly,
    /// The configuration provides the methods to parse command-line arguments and obtain Rewriters 
    /// </summary>
    public class AssemblyPlugin : ConfiguredPlugin
    {
        public AssemblyPlugin(Assembly assembly, string[] args) : base(LoadConfiguration(assembly, args))
        {
        }

        public static Plugin Load(string pluginPath, string[] args)
        {
            return new AssemblyPlugin(Assembly.LoadFrom(pluginPath), args);
        }

        public
          class AutomaticPluginConfiguration : PluginConfiguration
        {
            public AutomaticPluginConfiguration(Assembly assembly)
            {
                var types = assembly.GetTypes();

                Rewriters = FindPluginComponents<Rewriter, Func<ErrorReporter, Rewriter>>(assembly, CreateRewriterFactory);
                Compilers = FindPluginComponents<IExecutableBackend, Func<IExecutableBackend>>(assembly, CreateCompilerFactory);
                CompilerInstrumenters = FindPluginComponents<CompilerInstrumenter, Func<ErrorReporter, CompilerInstrumenter>>(assembly, CreateCompilerInstrumenterFactory);

                // Report an error if this assembly doesn't contain any plugins.  We only
                // get to this point if we have not found a `PluginConfiguration` either,
                // so no need to check for one here.
                if (MutateCSharp.Schemata355.ReplaceBinExprOp_2(34L, () => MutateCSharp.Schemata355.ReplaceBinExprOp_2(19L, () => MutateCSharp.Schemata355.ReplaceBinExprOp_1(5L, Rewriters.Length, MutateCSharp.Schemata355.ReplaceNumericConstant_0(1L, 0)), () => MutateCSharp.Schemata355.ReplaceBinExprOp_1(14L, Compilers.Length, MutateCSharp.Schemata355.ReplaceNumericConstant_0(10L, 0))), () => MutateCSharp.Schemata355.ReplaceBinExprOp_1(29L, CompilerInstrumenters.Length, MutateCSharp.Schemata355.ReplaceNumericConstant_0(25L, 0))))
                {
                    throw new Exception($"Plugin {assembly.Location} does not contain any supported plugin classes.  " +
            MutateCSharp.Schemata355.ReplaceStringConstant_3(40L, "Expecting one of the following:\n") +
                                        $"- ${typeof(Plugins.Rewriter).FullName}\n" +
                                        $"- ${typeof(Plugins.IExecutableBackend).FullName}\n" +
                                        $"- ${typeof(Plugins.CompilerInstrumenter).FullName}\n" +
                                        $"- ${typeof(Plugins.PluginConfiguration).FullName}");
                }
            }

            private TFactory[] FindPluginComponents<TSource, TFactory>(Assembly assembly, Func<System.Type, TFactory> createFactory)
            {
                return assembly.GetTypes()
                    .Where(type => type.IsAssignableTo(typeof(TSource)))
                    .Select(createFactory).ToArray();
            }

            private Func<ErrorReporter, Rewriter>[] Rewriters { get; init; }

            Func<ErrorReporter, Rewriter> CreateRewriterFactory(System.Type type) =>
              errorReporter => (Rewriter)Activator.CreateInstance(type, errorReporter);

            private Func<IExecutableBackend>[] Compilers { get; init; }
            private Func<ErrorReporter, CompilerInstrumenter>[] CompilerInstrumenters { get; init; }

            Func<IExecutableBackend> CreateCompilerFactory(System.Type type) =>
              () => (IExecutableBackend)Activator.CreateInstance(type);

            Func<ErrorReporter, CompilerInstrumenter> CreateCompilerInstrumenterFactory(System.Type type) =>
              errorReporter => (CompilerInstrumenter)Activator.CreateInstance(type, errorReporter);

            public override Rewriter[] GetRewriters(ErrorReporter errorReporter) =>
              Rewriters.Select(funcErrorReporterRewriter =>
                funcErrorReporterRewriter(errorReporter)).ToArray();

            public override IExecutableBackend[] GetCompilers(DafnyOptions options) =>
              Compilers.Select(c => c()).ToArray();

            public override CompilerInstrumenter[] GetCompilerInstrumenters(ErrorReporter reporter) =>
              CompilerInstrumenters.Select(c => c(reporter)).ToArray();
        }

        public static IEnumerable<System.Type> GetConfigurationsTypes(Assembly assembly)
        {
            return assembly.GetTypes()
              .Where(type => type.IsAssignableTo(typeof(PluginConfiguration)));
        }

        private static PluginConfiguration LoadConfiguration(Assembly assembly, string[] args)
        {
            PluginConfiguration pluginConfiguration = null;
            foreach (var configurationType in GetConfigurationsTypes(assembly))
            {
                if (MutateCSharp.Schemata355.ReplaceBinExprOp_4(41L, pluginConfiguration, null))
                {
                    throw new Exception(
                      $"Only one class should extend Microsoft.Dafny.Plugins.PluginConfiguration from {assembly.Location}. Please remove {configurationType}.");
                }

                pluginConfiguration = (PluginConfiguration)Activator.CreateInstance(configurationType);

                if (MutateCSharp.Schemata355.ReplaceBinExprOp_5(42L, pluginConfiguration, null))
                {
                    throw new Exception($"Could not instantiate a {configurationType} from {assembly.Location}");
                }

                pluginConfiguration.ParseArguments(args);
            }

            pluginConfiguration ??= new AutomaticPluginConfiguration(assembly);
            return pluginConfiguration;
        }

    }
}
