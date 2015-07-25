#if FALSE
using ICSharpCode.NRefactory.CSharp;

namespace cslib
{
    public class LintIssue
    {
        public int LineNumber;
        public int Column;
        public LintIssueIndex Index;
        public string[] Parameters;
        public string ReplacementText;
        public string OriginalText;

        public LintIssue()
        {
            this.Parameters = new string[0];
        }
        
        public LintIssue(AstNode node)
            : this()
        {
            this.LineNumber = node.StartLocation.Line;
            this.Column = node.StartLocation.Column;
        }
    }
}

#endif