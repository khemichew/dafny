using System.Diagnostics.Contracts;

namespace Microsoft.Dafny;
public 
class ResolverBottomUpVisitor : BottomUpVisitor {
  protected ModuleResolver resolver;
  public ResolverBottomUpVisitor(ModuleResolver resolver) {
    Contract.Requires(resolver != null);
    this.resolver = resolver;
  }
}