using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JsonPasteToJsonObjectFormatter
{
    public class NewtonsoftClassFormatter
    {
        private const string ClassSegmentPattern = @"(public class)\s+(\w+)";
        private const string PropertyPattern = @"(public)\s+(\w+.*)\s+(\w+)\s*(\{\s*get;\s*set;\s*})";

        public string GetFormatted(string input)
        {
            var classParser = new ClassParser();
            
            var rawClasses = classParser.FindClasses(input);
            var fixedClasses = rawClasses.Select(GetFixedClass);

            return string.Join("\r\n\r\n", fixedClasses);
        }

        private static string GetFixedClass(string input)
        {
            var matches = Regex.Matches(input, PropertyPattern);

            var sb = new StringBuilder();

            // fix properties
            foreach (Match match in matches)
            {
                var propertyName = match.Groups[3].Value;
                var decoration = $"\t[JsonProperty(\"{propertyName}\")]";

                var decoratedProperty = Regex.Replace(match.Value, PropertyPattern,
                    m => $"{decoration}\r\n\t{m.Groups[1].Value} {(IsSystemType(m.Groups[2].Value) ? m.Groups[2].Value : FixCase(m.Groups[2].Value))} {FixCase(propertyName)} {m.Groups[4]}\r\n");

                sb.AppendLine($"{decoratedProperty}");

            }

            // fix class name
            var classMatch = Regex.Match(input, ClassSegmentPattern);
            var className = FixCase(classMatch.Groups[2].Value);
            var r = $"{classMatch.Groups[1].Value} {className}\r\n{{\r\n{sb.ToString().TrimEnd('\r').TrimEnd('\n')}}}";

            return r;
        }

        private static bool IsSystemType(string input)
        {
            return new[] {"string", "int", "double", "decimal", "float", "object"}.Contains(input);
        }

        private static string FixCase(string input)
        {
            // look for snake case and spine cased
            var words = input.Split(new[] { "_", "-" }, StringSplitOptions.RemoveEmptyEntries);

            // convert to pascal cased
            var fixedWords = words.Select(s => char.ToUpper(s[0]) + s.Substring(1));
            var fixedCase = string.Join("", fixedWords);

            return fixedCase;
        }
    }
}
