#if FALSE
using ICSharpCode.NRefactory.CSharp;

namespace cslib
{
    public abstract class LintPolicy : DepthFirstAstVisitor
    {
        protected LintResults Results { get; private set; }

        protected LintPolicy(LintResults results)
        {
            this.Results = results;
        }
    }
}
#endif