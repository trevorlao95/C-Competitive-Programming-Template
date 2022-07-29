using System.Linq;

namespace CSharpCompProgrammingTemplate.Helpers.Snippets
{
    public static class IntHelpers
    {
        public static int TextToNumber(this string text)
        {
            return text
                .Select(c => c - 'A' + 1)
                .Aggregate((sum, next) => sum * 26 + next);
        }
    }
}