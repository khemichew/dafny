using Microsoft.Dafny.Plugins;

namespace Microsoft.Dafny.Compilers;
public class InternalBackendsPluginConfiguration : Plugins.PluginConfiguration {
  public static readonly InternalBackendsPluginConfiguration Singleton = new();

  public override IExecutableBackend[] GetCompilers(DafnyOptions options) {
    return new IExecutableBackend[] {
      new CsharpBackend(options),
      new JavaScriptBackend(options),
      new GoBackend(options),
      new JavaBackend(options),
      new PythonBackend(options),
      new CppBackend(options),
      new LibraryBackend(options),
      new RustBackend(options),
      new ResolvedDesugaredExecutableDafnyBackend(options)
    };
  }
}